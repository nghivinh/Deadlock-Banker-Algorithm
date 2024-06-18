using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace DEADLOCK_ALGORITHM
{
    public partial class Form1 : Form
    {
        #region MatrixArray
        //Tạo mảng cho từng ma trận
        private List<List<TextBox>> matrixAlloc;
        public List<List<TextBox>> MatrixAlloc { get => matrixAlloc; set => matrixAlloc = value; }

        private List<List<TextBox>> matrixMax;
        public List<List<TextBox>> MatrixMax { get => matrixMax; set => matrixMax = value; }

        private List<List<TextBox>> matrixNeed;
        public List<List<TextBox>> MatrixNeed { get => matrixNeed; set => matrixNeed = value; }

        private List<List<TextBox>> matrixAvai;
        public List<List<TextBox>> MatrixAvai { get => matrixAvai; set => matrixAvai = value; }

        private List<List<TextBox>> matrixWork;
        public List<List<TextBox>> MatrixWork { get => matrixWork; set => matrixWork = value; }

        private List<List<TextBox>> matrixReq;
        public List<List<TextBox>> MatrixReq { get => matrixReq; set => matrixReq = value; }

        private List<List<Label>> matrixLabelWork;
        public List<List<Label>> MatrixLabelWork { get => matrixLabelWork; set => matrixLabelWork = value; }

        private List<List<Label>> matrixLabelAlloc;
        public List<List<Label>> MatrixLabelAlloc { get => matrixLabelAlloc; set => matrixLabelAlloc = value; }

        private List<List<Label>> matrixLabelMax;
        public List<List<Label>> MatrixLabelMax { get => matrixLabelMax; set => matrixLabelMax = value; }

        private List<List<Label>> matrixLabelNeed;
        public List<List<Label>> MatrixLabelNeed { get => matrixLabelNeed; set => matrixLabelNeed = value; }
        #endregion
        #region Kho màu cho các Process
        int[,] color = { {130,238,238},
                         {240,128,128},
                         {144,238,144},
                         {255,160,122},
                         { 32,178,170},
                         {126, 6, 112},
                         {255, 99, 71},
                         {127,196,222},
                         {238,130,238},
                         {238,230,130},
                         { 16, 63,145},
                         {150, 79, 13},
                         { 52, 88,121},
                         {241,244,246},
                         {159,162,163},
                         {185,141, 19},
                         { 76,134, 88},
                         {180,121,168},
                         {213, 11, 35},
                         { 5, 106, 17},
                       };
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMatrix();
        }
        
        //Tạo Ma trận Textbox và Label cho các Ma trận
        void LoadMatrix()
        {   

            MatrixLabelAlloc = new List<List<Label>>();
            Label oldlabelAlloc = new Label() { Width = 35, Height = 20, Location = new Point(0, 30) };
            for (int i = 0; i < Cons.Dong; i++)
            {
                MatrixLabelAlloc.Add(new List<Label>());
                for (int j = 0; j < 1; j++)
                {
                    Label labelAlloc = new Label() { Width = 35, Height = 20, Location = new Point(0, 30) };
                    labelAlloc.Location = new Point(0, oldlabelAlloc.Location.Y);

                    labelAlloc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                    labelAlloc.Text = "P" + i;

                    pnlAlloc.Controls.Add(labelAlloc);
                    MatrixLabelAlloc[i].Add(labelAlloc);

                    oldlabelAlloc = labelAlloc;
                }
                oldlabelAlloc = new Label() { Width = 35, Height = 20, Location = new Point(0, oldlabelAlloc.Location.Y + Cons.heightText) };
            }
            MatrixAlloc = new List<List<TextBox>>();
            TextBox oldtextAlloc = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin * 2, 25) };
            for (int i = 0; i < Cons.Dong; i++)
            {
                MatrixAlloc.Add(new List<TextBox>());
                for (int j = 0; j < Cons.Cot; j++)
                {
                    TextBox textAlloc = new TextBox() { Width = Cons.widthText, Height = Cons.heightText };
                    textAlloc.Location = new Point(oldtextAlloc.Location.X + oldtextAlloc.Width + Cons.margin * 2 - 5, oldtextAlloc.Location.Y);
                    textAlloc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    switch (i)
                    {
                        case 0: textAlloc.BackColor = Color.FromArgb(color[0, 0], color[0, 1], color[0, 2]); break;
                        case 1: textAlloc.BackColor = Color.FromArgb(color[1, 0], color[1, 1], color[1, 2]); break;
                        case 2: textAlloc.BackColor = Color.FromArgb(color[2, 0], color[2, 1], color[2, 2]); break;
                        case 3: textAlloc.BackColor = Color.FromArgb(color[3, 0], color[3, 1], color[3, 2]); break;
                        case 4: textAlloc.BackColor = Color.FromArgb(color[4, 0], color[4, 1], color[4, 2]); break;
                        case 5: textAlloc.BackColor = Color.FromArgb(color[5, 0], color[5, 1], color[5, 2]); break;
                        case 6: textAlloc.BackColor = Color.FromArgb(color[6, 0], color[6, 1], color[6, 2]); break;
                        case 7: textAlloc.BackColor = Color.FromArgb(color[7, 0], color[7, 1], color[7, 2]); break;
                        case 8: textAlloc.BackColor = Color.FromArgb(color[8, 0], color[8, 1], color[8, 2]); break;
                        case 9: textAlloc.BackColor = Color.FromArgb(color[9, 0], color[9, 1], color[9, 2]); break;
                        case 10: textAlloc.BackColor = Color.FromArgb(color[10, 0], color[10, 1], color[10, 2]); break;
                        case 11: textAlloc.BackColor = Color.FromArgb(color[11, 0], color[11, 1], color[11, 2]); break;
                        case 12: textAlloc.BackColor = Color.FromArgb(color[12, 0], color[12, 1], color[12, 2]); break;
                        case 13: textAlloc.BackColor = Color.FromArgb(color[13, 0], color[13, 1], color[13, 2]); break;
                        case 14: textAlloc.BackColor = Color.FromArgb(color[14, 0], color[14, 1], color[14, 2]); break;
                        case 15: textAlloc.BackColor = Color.FromArgb(color[15, 0], color[15, 1], color[15, 2]); break;
                        case 16: textAlloc.BackColor = Color.FromArgb(color[16, 0], color[16, 1], color[16, 2]); break;
                        case 17: textAlloc.BackColor = Color.FromArgb(color[17, 0], color[17, 1], color[17, 2]); break;
                        case 18: textAlloc.BackColor = Color.FromArgb(color[18, 0], color[18, 1], color[18, 2]); break;
                        case 19: textAlloc.BackColor = Color.FromArgb(color[19, 0], color[19, 1], color[19, 2]); break;
                    }

                    pnlAlloc.Controls.Add(textAlloc);
                    MatrixAlloc[i].Add(textAlloc);

                    oldtextAlloc = textAlloc;
                }
                oldtextAlloc = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin * 2, oldtextAlloc.Location.Y + Cons.heightText) };
            }


            MatrixLabelMax = new List<List<Label>>();
            Label oldlabelMax = new Label() { Width = 35, Height = 20, Location = new Point(0, 30) };
            for (int i = 0; i < Cons.Dong; i++)
            {
                MatrixLabelMax.Add(new List<Label>());
                for (int j = 0; j < 1; j++)
                {
                    Label labelMax = new Label() { Width = 35, Height = 20, Location = new Point(0, 30) };
                    labelMax.Location = new Point(0, oldlabelMax.Location.Y);

                    labelMax.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                    labelMax.Text = "P" + i;

                    pnlMax.Controls.Add(labelMax);
                    MatrixLabelMax[i].Add(labelMax);

                    oldlabelMax = labelMax;
                }
                oldlabelMax = new Label() { Width = 35, Height = 20, Location = new Point(0, oldlabelMax.Location.Y + Cons.heightText) };
            }
            MatrixMax = new List<List<TextBox>>();
            TextBox oldtextMax = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin * 2, 25) };
            for (int i = 0; i < Cons.Dong; i++)
            {
                MatrixMax.Add(new List<TextBox>());
                for (int j = 0; j < Cons.Cot; j++)
                {
                    TextBox textMax = new TextBox() { Width = Cons.widthText, Height = Cons.heightText };
                    textMax.Location = new Point(oldtextMax.Location.X + oldtextMax.Width + Cons.margin * 2 - 5, oldtextMax.Location.Y);
                    textMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    switch (i)
                    {
                        case 0: textMax.BackColor = Color.FromArgb(color[0, 0], color[0, 1], color[0, 2]); break;
                        case 1: textMax.BackColor = Color.FromArgb(color[1, 0], color[1, 1], color[1, 2]); break;
                        case 2: textMax.BackColor = Color.FromArgb(color[2, 0], color[2, 1], color[2, 2]); break;
                        case 3: textMax.BackColor = Color.FromArgb(color[3, 0], color[3, 1], color[3, 2]); break;
                        case 4: textMax.BackColor = Color.FromArgb(color[4, 0], color[4, 1], color[4, 2]); break;
                        case 5: textMax.BackColor = Color.FromArgb(color[5, 0], color[5, 1], color[5, 2]); break;
                        case 6: textMax.BackColor = Color.FromArgb(color[6, 0], color[6, 1], color[6, 2]); break;
                        case 7: textMax.BackColor = Color.FromArgb(color[7, 0], color[7, 1], color[7, 2]); break;
                        case 8: textMax.BackColor = Color.FromArgb(color[8, 0], color[8, 1], color[8, 2]); break;
                        case 9: textMax.BackColor = Color.FromArgb(color[9, 0], color[9, 1], color[9, 2]); break;
                        case 10: textMax.BackColor = Color.FromArgb(color[10, 0], color[10, 1], color[10, 2]); break;
                        case 11: textMax.BackColor = Color.FromArgb(color[11, 0], color[11, 1], color[11, 2]); break;
                        case 12: textMax.BackColor = Color.FromArgb(color[12, 0], color[12, 1], color[12, 2]); break;
                        case 13: textMax.BackColor = Color.FromArgb(color[13, 0], color[13, 1], color[13, 2]); break;
                        case 14: textMax.BackColor = Color.FromArgb(color[14, 0], color[14, 1], color[14, 2]); break;
                        case 15: textMax.BackColor = Color.FromArgb(color[15, 0], color[15, 1], color[15, 2]); break;
                        case 16: textMax.BackColor = Color.FromArgb(color[16, 0], color[16, 1], color[16, 2]); break;
                        case 17: textMax.BackColor = Color.FromArgb(color[17, 0], color[17, 1], color[17, 2]); break;
                        case 18: textMax.BackColor = Color.FromArgb(color[18, 0], color[18, 1], color[18, 2]); break;
                        case 19: textMax.BackColor = Color.FromArgb(color[19, 0], color[19, 1], color[19, 2]); break;
                    }
                    pnlMax.Controls.Add(textMax);
                    MatrixMax[i].Add(textMax);

                    oldtextMax = textMax;
                }
                oldtextMax = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin * 2, oldtextMax.Location.Y + Cons.heightText) };
            }

            MatrixLabelNeed = new List<List<Label>>();
            Label oldlabelNeed = new Label() { Width = 35, Height = 20, Location = new Point(0, 30) };
            for (int i = 0; i < Cons.Dong; i++)
            {
                MatrixLabelNeed.Add(new List<Label>());
                for (int j = 0; j < 1; j++)
                {
                    Label labelNeed = new Label() { Width = 35, Height = 20, Location = new Point(0, 30) };
                    labelNeed.Location = new Point(0, oldlabelNeed.Location.Y);

                    labelNeed.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                    labelNeed.Text = "P" + i;

                    pnlNeed.Controls.Add(labelNeed);
                    MatrixLabelNeed[i].Add(labelNeed);

                    oldlabelNeed = labelNeed;
                }
                oldlabelNeed = new Label() { Width = 35, Height = 20, Location = new Point(0, oldlabelNeed.Location.Y + Cons.heightText) };
            }
            MatrixNeed = new List<List<TextBox>>();
            TextBox oldtextNeed = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin * 2, 25) };
            for (int i = 0; i < Cons.Dong; i++)
            {
                MatrixNeed.Add(new List<TextBox>());
                for (int j = 0; j < Cons.Cot; j++)
                {
                    TextBox textNeed = new TextBox() { Width = Cons.widthText, Height = Cons.heightText };
                    textNeed.Location = new Point(oldtextNeed.Location.X + oldtextNeed.Width + Cons.margin * 2 - 5, oldtextNeed.Location.Y);
                    textNeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    switch (i)
                    {
                        case 0: textNeed.BackColor = Color.FromArgb(color[0, 0], color[0, 1], color[0, 2]); break;
                        case 1: textNeed.BackColor = Color.FromArgb(color[1, 0], color[1, 1], color[1, 2]); break;
                        case 2: textNeed.BackColor = Color.FromArgb(color[2, 0], color[2, 1], color[2, 2]); break;
                        case 3: textNeed.BackColor = Color.FromArgb(color[3, 0], color[3, 1], color[3, 2]); break;
                        case 4: textNeed.BackColor = Color.FromArgb(color[4, 0], color[4, 1], color[4, 2]); break;
                        case 5: textNeed.BackColor = Color.FromArgb(color[5, 0], color[5, 1], color[5, 2]); break;
                        case 6: textNeed.BackColor = Color.FromArgb(color[6, 0], color[6, 1], color[6, 2]); break;
                        case 7: textNeed.BackColor = Color.FromArgb(color[7, 0], color[7, 1], color[7, 2]); break;
                        case 8: textNeed.BackColor = Color.FromArgb(color[8, 0], color[8, 1], color[8, 2]); break;
                        case 9: textNeed.BackColor = Color.FromArgb(color[9, 0], color[9, 1], color[9, 2]); break;
                        case 10: textNeed.BackColor = Color.FromArgb(color[10, 0], color[10, 1], color[10, 2]); break;
                        case 11: textNeed.BackColor = Color.FromArgb(color[11, 0], color[11, 1], color[11, 2]); break;
                        case 12: textNeed.BackColor = Color.FromArgb(color[12, 0], color[12, 1], color[12, 2]); break;
                        case 13: textNeed.BackColor = Color.FromArgb(color[13, 0], color[13, 1], color[13, 2]); break;
                        case 14: textNeed.BackColor = Color.FromArgb(color[14, 0], color[14, 1], color[14, 2]); break;
                        case 15: textNeed.BackColor = Color.FromArgb(color[15, 0], color[15, 1], color[15, 2]); break;
                        case 16: textNeed.BackColor = Color.FromArgb(color[16, 0], color[16, 1], color[16, 2]); break;
                        case 17: textNeed.BackColor = Color.FromArgb(color[17, 0], color[17, 1], color[17, 2]); break;
                        case 18: textNeed.BackColor = Color.FromArgb(color[18, 0], color[18, 1], color[18, 2]); break;
                        case 19: textNeed.BackColor = Color.FromArgb(color[19, 0], color[19, 1], color[19, 2]); break;
                    }
                    pnlNeed.Controls.Add(textNeed);
                    MatrixNeed[i].Add(textNeed);

                    oldtextNeed = textNeed;
                }
                oldtextNeed = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin * 2, oldtextNeed.Location.Y + Cons.heightText) };
            }

            MatrixLabelWork = new List<List<Label>>();
            Label oldlabelWork = new Label() { Width = 35, Height = 20, Location = new Point(0, 60) };
            for (int i = 0; i < Cons.Dong; i++)
            {
                MatrixLabelWork.Add(new List<Label>());
                for (int j = 0; j < 1; j++)
                {
                    Label labelWork = new Label() { Width = 35, Height = 20, Location = new Point(0, 60) };
                    labelWork.Location = new Point(0, oldlabelWork.Location.Y);

                    labelWork.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                    labelWork.Text = "";

                    pnlWork.Controls.Add(labelWork);
                    MatrixLabelWork[i].Add(labelWork);

                    oldlabelWork = labelWork;
                }
                oldlabelWork = new Label() { Width = 35, Height = 20, Location = new Point(0, oldlabelWork.Location.Y + Cons.heightText) };
            }
            MatrixWork = new List<List<TextBox>>();
            TextBox oldtextWork = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin * 2, 25) };
            for (int i = 0; i < Cons.Dong + 1; i++)
            {
                MatrixWork.Add(new List<TextBox>());
                for (int j = 0; j < Cons.Cot; j++)
                {
                    TextBox textWork = new TextBox() { Width = Cons.widthText, Height = Cons.heightText };
                    textWork.Location = new Point(oldtextWork.Location.X + oldtextWork.Width + Cons.margin * 2 - 5, oldtextWork.Location.Y);
                    textWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    pnlWork.Controls.Add(textWork);
                    MatrixWork[i].Add(textWork);

                    oldtextWork = textWork;
                }
                oldtextWork = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin * 2, oldtextWork.Location.Y + Cons.heightText) };
            }


            MatrixAvai = new List<List<TextBox>>();
            TextBox oldtextAvai = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin, 0) };
            for (int i = 0; i < 1; i++)
            {
                MatrixAvai.Add(new List<TextBox>());
                for (int j = 0; j < Cons.Cot; j++)
                {
                    TextBox textAvai = new TextBox() { Width = Cons.widthText, Height = Cons.heightText };
                    textAvai.Location = new Point(oldtextAvai.Location.X + oldtextAvai.Width + Cons.margin, oldtextAvai.Location.Y);
                    textAvai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    pnlAvai.Controls.Add(textAvai);
                    MatrixAvai[i].Add(textAvai);

                    oldtextAvai = textAvai;
                }
                oldtextAvai = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin, oldtextAvai.Location.Y + Cons.heightText) };
            }

            MatrixReq = new List<List<TextBox>>();
            TextBox oldtextReq = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin, 0) };
            for (int i = 0; i < 1; i++)
            {
                MatrixReq.Add(new List<TextBox>());
                for (int j = 0; j < Cons.Cot; j++)
                {
                    TextBox textReq = new TextBox() { Width = Cons.widthText, Height = Cons.heightText };
                    textReq.Location = new Point(oldtextReq.Location.X + oldtextReq.Width + Cons.margin, oldtextReq.Location.Y);
                    textReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    pnlReq.Controls.Add(textReq);
                    MatrixReq[i].Add(textReq);

                    oldtextReq = textReq;
                }
                oldtextReq = new TextBox() { Width = 0, Height = 0, Location = new Point(Cons.margin, oldtextReq.Location.Y + Cons.heightText) };
            }
        }

        //Xóa Ma trận Textbox và Label cho các Ma trận
        void ClearMatrix()
        {
            pnlAlloc.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Dispose());
            pnlAlloc.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Dispose());

            pnlMax.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Dispose());
            pnlMax.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Dispose());

            pnlNeed.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Dispose());
            pnlNeed.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Dispose());

            pnlWork.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Dispose());
            pnlWork.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Dispose());

            pnlAvai.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Dispose());

            pnlReq.Controls.OfType<TextBox>().ToList().ForEach(txt => txt.Dispose());

            fpnlResult.Controls.OfType<Button>().ToList().ForEach(btn => btn.Dispose());
        }

        //Tính Ma trận Need
        void FindNeed()
        {
            for (int i = 0; i < Cons.Dong; i++)
            {
                for (int j = 0; j < Cons.Cot; j++)
                {
                    int a = Convert.ToInt32(MatrixMax[i][j].Text) - Convert.ToInt32(MatrixAlloc[i][j].Text);
                    MatrixNeed[i][j].Text = a.ToString();
                    if (a < 0)
                    {
                        MessageBox.Show("Vui lòng xem dữ liệu nhập lại!\r\n\r\nMa trận Need không thể nhận số âm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        i = Cons.Dong - 1;
                        j = Cons.Cot - 1;
                    }
                }
            }
        }

        //Thay đổi lại 1 dòng của Ma trận Allocation khi có Request
        void ChangeAlloc()
        {   
            for (int i = 0; i < Cons.Dong; i++)
            {
                if (cbbReq.SelectedIndex == i)
                {
                    for (int j = 0; j < Cons.Cot; j++)
                    {
                        int a = Convert.ToInt32(MatrixAlloc[i][j].Text) + Convert.ToInt32(MatrixReq[0][j].Text);
                        MatrixAlloc[i][j].Text = a.ToString();
                    }
                    break;
                }
            }
            FindNeed();
        }

        //Tìm ma trận Work
        int[] safeSequence;//để lưu những process đã đi được (đã chọn rồi)
        int[,] processWait;//lưu những process có thể đi được (chưa được chọn)
        public void FindWork()
        {
            Cons.Dong = Convert.ToInt32(nudProcess.Value);
            safeSequence = new int[Cons.Dong];
            processWait = new int[2,Cons.Dong];
            int count = 0;
            int countWait = 0;

            //Cho tất cả Process là false
            Boolean[] visited = new Boolean[Cons.Dong];
            for (int i = 0; i < Cons.Dong; i++)
            {
                visited[i] = false;
            }

            //Ma trận work khởi tạo (work = avai hoặc work = avai - req)
            int[] work = new int[Cons.Cot];
            if (rabtnYes.Checked == false)
            {
                for (int j = 0; j < Cons.Cot; j++)
                {
                    work[j] = Convert.ToInt32(MatrixAvai[0][j].Text);
                    MatrixWork[0][j].Text = work[j].ToString();
                }
            }
            else
            {
                for (int j = 0; j < Cons.Cot; j++)
                {
                    int a = Convert.ToInt32(MatrixAvai[0][j].Text) - Convert.ToInt32(MatrixReq[0][j].Text);
                    work[j] = a;
                    MatrixWork[0][j].Text = work[j].ToString();
                }
            }

            int x = 1;//x là của ma trận work để xuống theo từng hàng
            while (count < Cons.Dong)
            {
                Boolean flag = false;//flag là đặt cờ, false là chưa đc chọn, true là được chọn
                for (int i = 0; i < Cons.Dong; i++)
                {
                    if (visited[i] == false || visited[Cons.Dong - 1] == true)
                    {
                        int j;
                        if (visited[i] == false)
                        {
                            for (j = 0; j < Cons.Cot; j++)
                            {
                                if (work[j] < Convert.ToInt32(MatrixNeed[i][j].Text))
                                    break;
                            }
                            if (j == Cons.Cot || i == Cons.Dong - 1)
                            {
                                //lưu tiến trình có thể cấp vào mảng processWait
                                if (j == Cons.Cot)
                                {
                                    int sumWork = Convert.ToInt32(MatrixWork[x - 1][0].Text) + Convert.ToInt32(MatrixWork[x - 1][1].Text) + Convert.ToInt32(MatrixWork[x - 1][2].Text);
                                    int sumNeed = Convert.ToInt32(MatrixNeed[i][0].Text) + Convert.ToInt32(MatrixNeed[i][1].Text) + Convert.ToInt32(MatrixNeed[i][2].Text);
                                    int sum = sumWork - sumNeed;
                                    for (int row = 0; row < 2; row++)
                                    {
                                        if (row == 0)
                                            processWait[row, countWait] = i;
                                        else processWait[row, countWait] = sum;
                                    }
                                    countWait++;
                                }
                                //Sau khi dò hết các tiến trình từ trên xuống
                                //Có được các tiến trình đã cấp
                                if (i == Cons.Dong - 1)
                                {
                                    if (countWait > 1)//trường hợp chỉ có 2 tiến trình trở lên
                                    {
                                        int choose;
                                        //Tìm số dư của banker lớn nhất trong các tiến trình có thể cấp
                                        int max = processWait[1, 0];//7
                                        for (int a = 1; a < countWait; a++)
                                        {
                                            if (processWait[1, a] > max)
                                            {
                                                max = processWait[1, a];
                                            }
                                            //khi kết thúc tìm SLN
                                            if (a == countWait - 1)
                                            {
                                                //Dò xem max đó của tiến trình nào 
                                                for (int col = 0; col < countWait; col++)
                                                {
                                                    if (processWait[1, col] == max)
                                                    {
                                                        choose = processWait[0, col];
                                                        safeSequence[count] = choose;
                                                        visited[choose] = true;
                                                        flag = true;
                                                        for (j = 0; j < Cons.Cot; j++)
                                                        {
                                                            work[j] = work[j] + Convert.ToInt32(MatrixAlloc[choose][j].Text);
                                                            MatrixWork[x][j].Text = work[j].ToString();
                                                            MatrixWork[x][j].BackColor = Color.FromArgb(color[safeSequence[count], 0], color[safeSequence[count], 1], color[safeSequence[count], 2]);
                                                        }
                                                        count++;
                                                        x++;
                                                        i = -1;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else //trường hợp chỉ có 1 tiến trình
                                    {
                                        safeSequence[count] = processWait[0, countWait - 1];
                                        visited[processWait[0, countWait - 1]] = true;
                                        flag = true;
                                        for (j = 0; j < Cons.Cot; j++)
                                        {
                                            work[j] = work[j] + Convert.ToInt32(MatrixAlloc[processWait[0, countWait - 1]][j].Text);
                                            MatrixWork[x][j].Text = work[j].ToString();
                                            MatrixWork[x][j].BackColor = Color.FromArgb(color[safeSequence[count], 0], color[safeSequence[count], 1], color[safeSequence[count], 2]);
                                        }
                                        count++;
                                        x++;
                                        i = -1;
                                    }
                                    //Clear ma trận procesWait
                                    for (int row = 0; row < 2; row++)
                                    {
                                        for (int col = 0; col < countWait; col++)
                                        {
                                            processWait[row, col] = 0;
                                        }
                                    }
                                    countWait = 0;
                                }
                            }
                        }
                        else if(visited[Cons.Dong - 1] == true)
                        {
                            if (i == Cons.Dong - 1)
                            {
                                if (countWait > 1)//trường hợp chỉ có 2 tiến trình trở lên
                                {
                                    int choose;
                                    //Tìm số dư của banker lớn nhất trong các tiến trình có thể cấp
                                    int max = processWait[1, 0];//7
                                    for (int a = 1; a < countWait; a++)
                                    {
                                        if (processWait[1, a] > max)
                                        {
                                            max = processWait[1, a];
                                        }
                                        //khi kết thúc tìm SLN
                                        if (a == countWait - 1)
                                        {
                                            //Dò xem max đó của tiến trình nào 
                                            for (int col = 0; col < countWait; col++)
                                            {
                                                if (processWait[1, col] == max)
                                                {
                                                    choose = processWait[0, col];
                                                    safeSequence[count] = choose;
                                                    visited[choose] = true;
                                                    flag = true;
                                                    for (j = 0; j < Cons.Cot; j++)
                                                    {
                                                        work[j] = work[j] + Convert.ToInt32(MatrixAlloc[choose][j].Text);
                                                        MatrixWork[x][j].Text = work[j].ToString();
                                                        MatrixWork[x][j].BackColor = Color.FromArgb(color[safeSequence[count], 0], color[safeSequence[count], 1], color[safeSequence[count], 2]);
                                                    }
                                                    count++;
                                                    x++;
                                                    i = -1;
                                                }
                                            }
                                        }
                                    }
                                }
                                else if(countWait == 1)//trường hợp chỉ có 1 tiến trình
                                {
                                    safeSequence[count] = processWait[0, countWait - 1];
                                    visited[processWait[0, countWait - 1]] = true;
                                    flag = true;
                                    for (j = 0; j < Cons.Cot; j++)
                                    {
                                        work[j] = work[j] + Convert.ToInt32(MatrixAlloc[processWait[0, countWait - 1]][j].Text);
                                        MatrixWork[x][j].Text = work[j].ToString();
                                        MatrixWork[x][j].BackColor = Color.FromArgb(color[safeSequence[count], 0], color[safeSequence[count], 1], color[safeSequence[count], 2]);
                                    }
                                    count++;
                                    x++;
                                    i = -1;
                                }
                                //Clear ma trận procesWait
                                for (int row = 0; row < 2; row++)
                                {
                                    for (int col = 0; col < countWait; col++)
                                    {
                                        processWait[row, col] = 0;
                                    }
                                }
                                countWait = 0;
                            }
                        }
                    }
                }
                if (flag == false)
                {
                    break;
                }
            }
            if (count < Cons.Dong)
            {
                MessageBox.Show("Hệ thống không an toàn!\r\n\r\n(The System is Unsafe!)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Button btn = new Button();
                for (int i = 0; i < Cons.Dong; i++)
                {
                    btn = new Button() { Width = 100, Height = 40 };
                    btn.Text = "P" + safeSequence[i];
                    btn.BackColor = Color.FromArgb(color[safeSequence[i], 0], color[safeSequence[i], 1], color[safeSequence[i], 2]);
                    btn.Font = new Font("Tahoma", 11F, FontStyle.Bold);
                    fpnlResult.Controls.Add(btn);

                    MatrixLabelWork[i][0].Text = "P" + safeSequence[i].ToString();
                }
            }
        }

        //Tạo Biểu đồ
        void Chart()
        {
            chartResult.ChartAreas["ChartArea1"].AxisX.Title = "Tiến trình";
            chartResult.ChartAreas["ChartArea1"].AxisY.Title = "Giá trị";
            for (int i = 1; i < Cons.Dong + 1; i++)
            {
                chartResult.Series["Series1"].Points.AddXY(safeSequence[i - 1].ToString(), Convert.ToInt32(MatrixWork[i][0].Text));
                chartResult.Series["Series2"].Points.AddXY(safeSequence[i - 1].ToString(), Convert.ToInt32(MatrixWork[i][1].Text));
                chartResult.Series["Series3"].Points.AddXY(safeSequence[i - 1].ToString(), Convert.ToInt32(MatrixWork[i][2].Text));
            }
            
        }

        void ClearChart()
        {
            chartResult.ChartAreas["ChartArea1"].AxisX.Title = "Tiến trình";
            chartResult.ChartAreas["ChartArea1"].AxisY.Title = "Giá trị";
            for (int i = 1; i < Cons.Dong + 1; i++)
            {
                for (int j = 0; j < Cons.Cot; j++)
                {
                    chartResult.Series["Series1"].Points.Clear();
                    chartResult.Series["Series2"].Points.Clear();
                    chartResult.Series["Series3"].Points.Clear();
                }
            }

        }

        //Tính toán
        private void btnCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                if (MatrixNeed[0][0].Text != "")
                {
                    if (rabtnYes.Checked == false)
                    {
                        ClearChart();
                        fpnlResult.Controls.OfType<Button>().ToList().ForEach(btn => btn.Dispose());
                        FindNeed();
                        FindWork();
                        Chart();
                    }
                    else
                    {
                        int a, b, c;
                        a = Convert.ToInt32(MatrixReq[0][0].Text);
                        b = Convert.ToInt32(MatrixReq[0][1].Text);
                        c = Convert.ToInt32(MatrixReq[0][2].Text);
                        if (cbbReq.SelectedIndex == -1)
                        {
                            MessageBox.Show("Chưa chọn Process muốn Request", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            ClearChart();
                            MatrixReq[0][0].Text = "0";
                            MatrixReq[0][1].Text = "0";
                            MatrixReq[0][2].Text = "0";
                            fpnlResult.Controls.OfType<Button>().ToList().ForEach(btn => btn.Dispose());
                            ChangeAlloc();
                            MatrixReq[0][0].Text = a.ToString();
                            MatrixReq[0][1].Text = b.ToString();
                            MatrixReq[0][2].Text = c.ToString();
                            FindWork();
                            Chart();
                        }
                    }
                }
                else
                {
                    if (rabtnYes.Checked == false)
                    {
                        ClearChart();
                        FindNeed();
                        FindWork();
                        Chart();
                    }
                    else
                    {
                        if (cbbReq.SelectedIndex == -1)
                        {
                            MessageBox.Show("Chưa chọn Process muốn Request", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            ClearChart();
                            ChangeAlloc();
                            FindWork();
                            Chart();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu hoặc bị lỗi.\r\n\r\nVui lòng nhấn nút Làm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Thay đổi radiobutton
        private void rabtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rabtnYes.Checked == false)
            {
                rabtnNo.Checked = true;
                cbbReq.Enabled = false;
                pnlReq.Enabled = false;
                pnlReq.BackColor = Color.Gray;
                pnlReqq.BackColor = Color.Gray;
                cbbReq.Text = "Request (Process)";
            }
            else
            {
                rabtnNo.Checked = false;
                cbbReq.Enabled = true;
                pnlReq.Enabled = true;
                if (cbbBgColor.SelectedIndex == 0)
                {
                    pnlReq.BackColor = Color.Blue;
                    pnlReqq.BackColor = Color.Blue;
                }
                if (cbbBgColor.SelectedIndex == 1)
                {
                    pnlReq.BackColor = Color.DarkOrange;
                    pnlReqq.BackColor = Color.DarkOrange;
                }
                else
                {
                    pnlReq.BackColor = Color.Blue;
                    pnlReqq.BackColor = Color.Blue;
                }
            }
        }

        //Đổi tone màu
        private void cbbBgColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbBgColor.SelectedIndex == 0)
            {
                BackColor = System.Drawing.SystemColors.ActiveCaption;
                pnlAlloc.BackColor = Color.Yellow;
                pnlAllocc.BackColor = Color.Yellow;
                pnlMax.BackColor = Color.Lime;
                pnlMaxx.BackColor = Color.Lime;
                pnlNeed.BackColor = Color.DodgerBlue;
                pnlNeedd.BackColor = Color.DodgerBlue;
                pnlWork.BackColor = Color.Red;
                pnlWorkk.BackColor = Color.Red;
                pnlAvai.BackColor = Color.DarkOrange;
                pnlAvaii.BackColor = Color.DarkOrange;
                pnlReq.BackColor = Color.Blue;
                pnlReqq.BackColor = Color.Blue;
                btnCalculator.BackColor = Color.DarkGray;

                ForeColor = System.Drawing.Color.Black;
                lblAllocA.ForeColor = Color.Black;
                lblAllocB.ForeColor = Color.Black;
                lblAllocC.ForeColor = Color.Black;
                pnlAlloc.ForeColor = Color.Black;
                lblMaxA.ForeColor = Color.Black;
                lblMaxB.ForeColor = Color.Black;
                lblMaxC.ForeColor = Color.Black;
                pnlMax.ForeColor = Color.Black;
                lblNeedA.ForeColor = Color.Black;
                lblNeedB.ForeColor = Color.Black;
                lblNeedC.ForeColor = Color.Black;
                pnlNeed.ForeColor = Color.Black;
                lblWorkA.ForeColor = Color.Black;
                lblWorkB.ForeColor = Color.Black;
                lblWorkC.ForeColor = Color.Black;
                pnlWork.ForeColor = Color.Black;
                lblAvaiA.ForeColor = Color.Black;
                lblAvaiB.ForeColor = Color.Black;
                lblAvaiC.ForeColor = Color.Black;
                btnCalculator.ForeColor = Color.Black;
            }

            if (cbbBgColor.SelectedIndex == 1)
            {
                BackColor = System.Drawing.Color.Gold;
                pnlAlloc.BackColor = Color.FromArgb(252, 153, 60);
                pnlAllocc.BackColor = Color.FromArgb(252, 153, 60);
                pnlMax.BackColor = Color.FromArgb(242, 117, 0);
                pnlMaxx.BackColor = Color.FromArgb(242, 117, 0);
                pnlNeed.BackColor = Color.Chocolate;
                pnlNeedd.BackColor = Color.Chocolate;
                pnlWork.BackColor = Color.FromArgb(165, 82, 4);
                pnlWorkk.BackColor = Color.FromArgb(165, 82, 4);
                pnlAvai.BackColor = Color.Orange;
                pnlAvaii.BackColor = Color.Orange;
                pnlReq.BackColor = Color.DarkOrange;
                pnlReqq.BackColor = Color.DarkOrange;
                btnCalculator.BackColor = Color.Coral;

                ForeColor = System.Drawing.Color.OrangeRed;
                lblAllocA.ForeColor = Color.White;
                lblAllocB.ForeColor = Color.White;
                lblAllocC.ForeColor = Color.White;
                pnlAlloc.ForeColor = Color.White;
                lblMaxA.ForeColor = Color.White;
                lblMaxB.ForeColor = Color.White;
                lblMaxC.ForeColor = Color.White;
                pnlMax.ForeColor = Color.White;
                lblNeedA.ForeColor = Color.White;
                lblNeedB.ForeColor = Color.White;
                lblNeedC.ForeColor = Color.White;
                pnlNeed.ForeColor = Color.White;
                lblWorkA.ForeColor = Color.White;
                lblWorkB.ForeColor = Color.White;
                lblWorkC.ForeColor = Color.White;
                pnlWork.ForeColor = Color.White;
                lblAvaiA.ForeColor = Color.White;
                lblAvaiB.ForeColor = Color.White;
                lblAvaiC.ForeColor = Color.White;
                btnCalculator.ForeColor = Color.White;

            }
        }

        //Khi tăng giảm giá trị trong NumericUpDown
        private void nudProcess_ValueChanged(object sender, EventArgs e)
        {
            Cons.Dong = Convert.ToInt32(nudProcess.Value);
            ClearMatrix();
            LoadMatrix();

            cbbReq.Items.Clear();
            for (int i = 0; i < Cons.Dong; i++)
            {
                cbbReq.Items.Add("Resquest (P" + i +")");
            }
        }

        //Làm mới Form
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearChart();
            ClearMatrix();
            LoadMatrix();
            nudProcess.Value = 0;
            rabtnYes.Checked = true;
            if (cbbBgColor.SelectedIndex == 0 || cbbBgColor.SelectedIndex == -1)
            {
                pnlReq.BackColor = Color.Blue;
                pnlReqq.BackColor = Color.Blue;
            }
            else
            {
                pnlReq.BackColor = Color.DarkOrange;
                pnlReqq.BackColor = Color.DarkOrange;
            }
            cbbReq.Items.Clear();
            cbbReq.Text = "Request (Process)";
            
        }

        //Tự nhập dữ liệu
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            for (int i = 0; i < Cons.Dong; i++)
            {
                for (int j = 0; j < Cons.Cot; j++)
                {
                    int alloc = random.Next(0, Cons.maxRadom);
                    MatrixAlloc[i][j].Text = alloc.ToString();

                    int max = random.Next(0, Cons.maxRadom);
                    do
                    {
                        max = random.Next(0, Cons.maxRadom);
                    }
                    while (max < alloc);
                    MatrixMax[i][j].Text = max.ToString();

                    int avai = random.Next(0, Cons.maxRadom);
                    MatrixAvai[0][j].Text = avai.ToString();

                    //Nếu radiobutton "Có nhận Request" bật thì tạo số ngẫu nhiên
                    if (rabtnYes.Checked == true)
                    {
                        int cbbreq = random.Next(0, Cons.Dong - 1);
                        cbbReq.SelectedIndex = cbbreq;

                        int req = random.Next(0, Cons.maxRadom);
                        do
                        {
                            req = random.Next(0, Cons.maxRadom);
                        }
                        while (req > avai || (alloc + req) > max);
                        MatrixReq[0][j].Text = req.ToString();
                    }
                    //Còn không thì xóa dữ liệu trên ma trận Request
                    else
                    {
                        for(int cot = 0; cot < Cons.Cot; cot++)
                        {
                            MatrixReq[0][cot].Text = "";
                        }
                        cbbReq.Text = "Request (Process)";
                    }
                }
            }
        }

        //Lấy dữ liệu Test
        private void btnRandomE_Click(object sender, EventArgs e)
        {
            if (nudProcess.Value != 5)
            {
                MessageBox.Show("Vui lòng chọn Số tiến trình là: 5", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MatrixAlloc[0][0].Text = "3"; MatrixAlloc[0][1].Text = "0"; MatrixAlloc[0][2].Text = "1";
                MatrixAlloc[1][0].Text = "3"; MatrixAlloc[1][1].Text = "2"; MatrixAlloc[1][2].Text = "1";
                MatrixAlloc[2][0].Text = "2"; MatrixAlloc[2][1].Text = "1"; MatrixAlloc[2][2].Text = "3";
                MatrixAlloc[3][0].Text = "0"; MatrixAlloc[3][1].Text = "3"; MatrixAlloc[3][2].Text = "0";
                MatrixAlloc[4][0].Text = "1"; MatrixAlloc[4][1].Text = "1"; MatrixAlloc[4][2].Text = "2";

                MatrixMax[0][0].Text = "10"; MatrixMax[0][1].Text = "7"; MatrixMax[0][2].Text = "4";
                MatrixMax[1][0].Text = "8"; MatrixMax[1][1].Text = "5"; MatrixMax[1][2].Text = "3";
                MatrixMax[2][0].Text = "6"; MatrixMax[2][1].Text = "3"; MatrixMax[2][2].Text = "4";
                MatrixMax[3][0].Text = "9"; MatrixMax[3][1].Text = "6"; MatrixMax[3][2].Text = "3";
                MatrixMax[4][0].Text = "7"; MatrixMax[4][1].Text = "4"; MatrixMax[4][2].Text = "5";

                MatrixAvai[0][0].Text = "6"; MatrixAvai[0][1].Text = "2"; MatrixAvai[0][2].Text = "2";

                MatrixReq[0][0].Text = "2"; MatrixReq[0][1].Text = "0"; MatrixReq[0][2].Text = "1";

                cbbReq.SelectedIndex = 2;
            }
        }

        //Thoát chương trình
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
