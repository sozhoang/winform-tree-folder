using System.CodeDom.Compiler;

namespace ApplicationOfDP
{
    public partial class Form1 : Form
    {
        int numFol;
        int numIte;
        bool CheckAll;
        Mediator _med = new Mediator();
        Visitor _vis = new Visitor();
        public Form1()
        {
            InitializeComponent();
        }

        // Explore the subfolder from folder 
        void LoadExplore(TreeNode root)
        {
            if (root == null)
                return;
            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();
                string[] fileList = Directory.GetFiles(root.Text);
                numFol += folderList.Length;
                if (folderList.Count() == 0 && fileList.Length == 0)
                {
                    return;
                }
                foreach (DirectoryInfo folder in folderList)
                {
                    if (Directory.Exists(folder.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = folder.FullName };
                        root.Nodes.Add(node);
                        node.ImageIndex = 0;
                        LoadExplore(node);
                    }
                }

                // the default display doesn't include files
                if(CheckAll)
                {
                    foreach (string file in fileList)
                    {
                        TreeNode node = new TreeNode() { Text = file };
                        Items it = _vis.CreateObject(file);
                        if (_med._manager[it.extension])
                        {
                            node.ImageIndex = it._index;
                            root.Nodes.Add(node);
                            numIte++;
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        // export the file's names from its path
        void ChangeName(TreeNode root)
        {
            if (root == null)
                return;
            var lst = root.Nodes;

            root.Text = new DirectoryInfo(root.Text).Name;
            foreach (TreeNode node in lst)
            {
                ChangeName(node);
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            string path = @"";
            numFol = 0;
            numIte = 0;
            TreeNode root = new TreeNode();
            tvTreeFolder.Nodes.Clear();
            path += txtPath.Text;
            if (Directory.Exists(path))
            {
                root.Text = path;
                tvTreeFolder.Nodes.Add(root);
                root.ImageIndex = 0;

                CheckAll = false;   // check the state of the checkboxes to decide the type of Treeview's display
                foreach (KeyValuePair<string, bool> k in _med._manager)
                {
                    CheckAll = CheckAll || k.Value;
                }

                LoadExplore(root);
                txtNumItems.Text = (numFol + 1).ToString() + " folders | " + (numIte).ToString() + " items";
                ChangeName(root);
            }
            else
            {
                MessageBox.Show("The specified path does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool _all
        {
            set{ cbAll.Checked = value; }
            get { return cbAll.Checked; }
        }
        public bool _image
        {
            set { cbImage.Checked = value; }
            get { return cbImage.Checked; }
        }
        public bool _video
        {
            set { cbVideo.Checked = value; }
            get { return cbVideo.Checked; }
        }
        public bool _word
        {
            set { cbWord.Checked = value; }
            get { return cbWord.Checked; }
        }
        public bool _excel
        {
            set { cbExcel.Checked = value; }
            get { return cbExcel.Checked; }
        }
        public bool _pdf
        {
            set { cbPDF.Checked = value; }
            get { return cbPDF.Checked; }
        }
        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            _med.Notify("unknown");
        }       
        private void cbImage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)
                cbImage.Checked = true;
            _med.Notify(".jpg");
            _med.Notify(".png");
        }
        private void cbVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)           
                cbVideo.Checked = true;            
            _med.Notify(".mp4");
        }
        private void cbWord_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAll.Checked)
                cbWord.Checked = true;
            _med.Notify(".docx");
        }

        private void cbExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)
                cbExcel.Checked = true;
            _med.Notify(".xlsx");
        }

        private void cbPDF_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)
                cbPDF.Checked = true;
            _med.Notify(".pdf");
        }
    }
}