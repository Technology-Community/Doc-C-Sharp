using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Globalization;

namespace DirectoryManagement
{
    public partial class Explorer : Form
    {
        public Explorer()
        {
            InitializeComponent();
            PopulateDriveList();
        }

        /// <summary>
        /// Lấy Danh sách các ổ đĩa.
        /// </summary>
        /// <returns></returns>
        protected ManagementObjectCollection GetDrivers()
        {
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();

            return queryCollection;
        }

        /// <summary>
        /// Khởi tạo Listview
        /// </summary>
        protected void InitListView()
        {
            // Khởi tạo Listview ban đầu
            lvFiles.Clear();
            //// Tạo các header cho Listview
            lvFiles.Columns.Add("Tên File", 140, HorizontalAlignment.Left);
            lvFiles.Columns.Add("Dung Lượng", 75, HorizontalAlignment.Right);
            lvFiles.Columns.Add("Ngày Tạo", 140, HorizontalAlignment.Right);
            lvFiles.Columns.Add("Ngày Sửa", 140, HorizontalAlignment.Right);
        }

        private void PopulateDriveList()
        {
            TreeNode nodeTreeNode;
            int imageIndex = 0;
            int selectIndex = 0;

            const int Removable = 2;
            const int LocalDisk = 3;
            const int Network = 4;
            const int CD = 5;

            this.Cursor = Cursors.WaitCursor;
            // Xóa Treeview
            tvFolders.Nodes.Clear();
            nodeTreeNode = new TreeNode("My Computer", 0, 0);
            tvFolders.Nodes.Add(nodeTreeNode);

            // Thiết lập tập hợp các Node
            TreeNodeCollection nodeCollection = nodeTreeNode.Nodes;

            // Lấy danh sách các ổ đĩa
            ManagementObjectCollection queryCollection = GetDrivers();

            foreach (ManagementObject mo in queryCollection)
            {
                switch (int.Parse(mo["DriveType"].ToString()))
                {
                    case Removable:			// Các Ổ Đĩa Mềm
                        imageIndex = 5;
                        selectIndex = 5;
                        break;
                    case LocalDisk:			// Các Ổ Đĩa Cứng
                        imageIndex = 6;
                        selectIndex = 6;
                        break;
                    case CD:				// Các Ổ Đĩa CD
                        imageIndex = 7;
                        selectIndex = 7;
                        break;
                    case Network:			// Các Ổ Liên Kết qua mạng
                        imageIndex = 8;
                        selectIndex = 8;
                        break;
                    default:				
                        imageIndex = 2;
                        selectIndex = 3;
                        break;
                }
                // Tạo một Driver Node mới
                nodeTreeNode = new TreeNode(mo["Name"].ToString() + "\\", imageIndex, selectIndex);

                // Chèn vào Treeview
                nodeCollection.Add(nodeTreeNode);

            }

            InitListView();
            this.Cursor = Cursors.Default;
            
        }

        private void tvFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Phân bố thư mục hoặc File khi một thư mục được chọn
            this.Cursor = Cursors.WaitCursor;
            
            // Lấy ổ đĩa hoặc thư mục đang được lựa chọn
            TreeNode currentNode = e.Node;
            
            // Xóa toàn bộ thư mục con
            currentNode.Nodes.Clear();

            if (currentNode.SelectedImageIndex == 0)
            {
                // My Computer được chọn - Phân bố lại danh sách các ổ đĩa.
                PopulateDriveList();
            }
            else
            {
                // Phân bố các thư mục con và các File.
                PopulateDirectory(currentNode, currentNode.Nodes);
            }
            this.Cursor = Cursors.Default;

        }

        protected void PopulateDirectory(TreeNode currentNode, TreeNodeCollection currentNodeCollection)
        {
            TreeNode nodeDir;
            int imageIndex = 2;  // Chỉ mục ảnh khi không được chọn
            int selectIndex = 3; // Chỉ mục ảnh khi được chọn.

            if (currentNode.SelectedImageIndex != 0)
            {
                // phân bố các thư mục trong Treeview
                try
                {
                    // Kiểm tra đường dẫn
                    if (Directory.Exists(GetFullPath(currentNode.FullPath)) == false)
                    {
                        MessageBox.Show("Ổ đĩa hoặc thư mục " + currentNode.ToString() + " Không tồn tại");
                    }
                    else
                    {
                        //Phân bố các Files.
                        PopulateFiles(currentNode);

                        string[] stringDirectories = Directory.GetDirectories(GetFullPath(currentNode.FullPath));
                        string stringFullPath = "";
                        string stringPathName = "";

                        // Lặp qua tất cả các thư mục
                        foreach (string stringDir in stringDirectories)
                        {
                            stringFullPath = stringDir;
                            stringPathName = GetPathName(stringDir);

                            // Tạo các Node cho thư mục
                            nodeDir = new TreeNode(stringPathName.ToString(), imageIndex, selectIndex);
                            currentNodeCollection.Add(nodeDir);
                        }
                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show("Lỗi: Ổ đĩa không có hoặc thư mục không tồn tại.");
                }
                catch (UnauthorizedAccessException e)
                {
                    MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào ổ đĩa hoặc thư mục này");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi " + e);
                }
            }
        }

        /// <summary>
        /// Phân bố các File vào Listview.
        /// </summary>
        /// <param name="currentNode"></param>
        protected void PopulateFiles(TreeNode currentNode)
        {
            string[] lvData = new string[4];

            InitListView();

            if (currentNode.SelectedImageIndex != 0)
            {
                // Kiểm tra đường dẫn
                if (Directory.Exists(GetFullPath(currentNode.FullPath)) == false)
                {
                    MessageBox.Show("Thư mục hoặc đường dẫn" + currentNode.ToString() + "Không tồn tại");
                }
                else
                {
                    try
                    {
                        string[] stringFiles = Directory.GetFiles(GetFullPath(currentNode.FullPath));
                        string stringFileName = null;
                        DateTime dtCreateDate, dtModifyDate;
                        Int64 lFileSize = 0;

                        // Duyệt tất cả các File.
                        foreach (string stringFile in stringFiles)
                        {
                            stringFileName = stringFile;
                            FileInfo objFileSize = new FileInfo(stringFileName);
                            lFileSize = objFileSize.Length;
                            dtCreateDate = objFileSize.CreationTime;
                            dtModifyDate = objFileSize.LastWriteTime;

                            // Ghi dữ liệu vào Listview
                            lvData[0] = GetPathName(stringFileName);
                            lvData[1] = FormatSize(lFileSize);

                            lvData[2] = FormatDate(dtCreateDate);
                        
                            lvData[3] = FormatDate(dtModifyDate);
                          
                            ListViewItem lvItem = new ListViewItem(lvData, 0);
                            lvFiles.Items.Add(lvItem);

                        }

                    }

                    catch (IOException e)
                    {
                        MessageBox.Show("Lỗi: Ổ đĩa không có hoặc thư mục không tồn tại.");
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        MessageBox.Show("Lỗi: Bạn không có quyền truy cập vào ổ đĩa hoặc thư mục này");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Lỗi " + e);
                    }
                }
            }
        }

        /// <summary>
        /// Chuyển sang định dạng ngày giờ Ngắn.
        /// </summary>
        /// <param name="dtDate"></param>
        /// <returns></returns>
        protected string FormatDate(DateTime dtDate)
        {
            string stringDate = "";
            stringDate = dtDate.ToShortDateString().ToString() + " " + dtDate.ToShortTimeString().ToString();

            return stringDate;
        }

        /// <summary>
        /// Chuyển định dạng từ Số sang KB
        /// </summary>
        /// <param name="lSize"></param>
        /// <returns></returns>
        protected string FormatSize(Int64 lSize)
        {
            string stringSize = "";
            NumberFormatInfo myNfi = new NumberFormatInfo();

            Int64 lKBSize = 0;
            if (lSize < 1024)
            {
                if (lSize == 0)
                {
                    stringSize = "0";
                }
                else
                    stringSize = "1"; // Dung Lượng lớn hơn 0 và nhỏ hơn 1024 làm tròn thành 1 KB
            }
            else
            {
                lKBSize = lSize / 1024;
                // Chuyển sang định dạng chuẩn
                stringSize = lKBSize.ToString("n",myNfi);
                // Cắt bỏ phần thập phân.
                stringSize = stringSize.Replace(".00", "");
            }

            return stringSize + " KB";
        }

        /// <summary>
        /// Lấy tên của thư mục
        /// </summary>
        /// <param name="stringPath"></param>
        /// <returns></returns>
        protected string GetPathName(string stringPath)
        {
            string[] stringSplit = stringPath.Split('\\');
            int _maxIndex = stringSplit.Length;

            return stringSplit[_maxIndex - 1];
        }

        /// <summary>
        /// Lấy Đường dẫn đầy đủ.
        /// </summary>
        /// <param name="stringPath"></param>
        /// <returns></returns>
        protected string GetFullPath(string stringPath)
        {
            string stringParse = "";
            // Xóa bỏ My Computer khỏi đường dẫn
            stringParse = stringPath.Replace("My Computer\\", "");

            return stringParse;
        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();

        }

        

    }

}