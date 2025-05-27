namespace AddContactForm.cs
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }
        private TextBox txtHo;
        private TextBox txtTen;
        private Button btnLuu;

        private void InitializeComponent()
        {
            txtHo = new TextBox();
            txtTen = new TextBox();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // txtHo
            // 
            txtHo.Location = new Point(172, 76);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(125, 27);
            txtHo.TabIndex = 0;
            txtHo.Text = "Họ Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(599, 76);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 1;
            txtTen.Text = "SĐT";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(379, 262);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 42);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            ClientSize = new Size(944, 484);
            Controls.Add(btnLuu);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Name = "AddContactForm";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
