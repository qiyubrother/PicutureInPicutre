using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureInPicture
{
    public partial class FrmMain : Form
    {
        PictureInPictureManager mgr = new PictureInPictureManager();
        public FrmMain()
        {
            InitializeComponent();

            //lblScreenSize.Text = $"{Screen.AllScreens[0].Bounds.ToString()} >> {Screen.AllScreens[1].Bounds.ToString()} >> {Screen.AllScreens[2].Bounds.ToString()}";
        }

        bool isMouseDown = false;
        int scale = 4;
        int rectWidth = 16;
        int rectHeight = 9;
        int x = 0;
        int y = 0;
        private void pnlContainer_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            txtLeft.Text = (e.X * scale).ToString();
            txtTop.Text = (e.Y * scale).ToString();

            pnlContainer.Invalidate();
        }

        private void pnlContainer_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            pnlContainer.Invalidate();

            PictureInPuctureObject item = null;
            item = mgr.GetItemByvideoNo(listBoxVideoNo.SelectedIndex);
            if (item != null)
            {
                item.Left = Convert.ToInt32(txtLeft.Text);
                item.Top = Convert.ToInt32(txtTop.Text);
                item.Width = Convert.ToInt32(txtWidth.Text);
                item.Height = Convert.ToInt32(txtHeight.Text);
            }
        }

        private void pnlContainer_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                PictureInPuctureObject item = null;
                item = mgr.GetItemByvideoNo(listBoxVideoNo.SelectedIndex);
                if (item != null)
                {
                    item.Left = Convert.ToInt32(txtLeft.Text);
                    item.Top = Convert.ToInt32(txtTop.Text);
                    item.Width = Convert.ToInt32(txtWidth.Text);
                    item.Height = Convert.ToInt32(txtHeight.Text);
                }
                txtLeft.Text = (e.X * scale).ToString();
                txtTop.Text = (e.Y * scale).ToString();
                if (!chkAuxiliaryLines.Checked)
                {
                    pnlContainer.Invalidate();
                }
            }
            x = e.X;
            y = e.Y;
            if (chkAuxiliaryLines.Checked)
            {
                pnlContainer.Invalidate();
            }
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {
            var pens = new[] {
                new Pen(new SolidBrush(Color.Red)),
                new Pen(new SolidBrush(Color.Yellow)),
                new Pen(new SolidBrush(Color.Green))
            };

            var bmp = new Bitmap(pnlContainer.Width, pnlContainer.Height);
            var g = Graphics.FromImage(bmp);

            for (var i = 0; i < 3; i++)
            {
                var item = mgr.GetItemByvideoNo(i);
                if (item != null)
                {
                    var rect = new Rectangle { X = Convert.ToInt32(item.Left) / scale, Y = Convert.ToInt32(item.Top) / scale, Width = item.Width / scale, Height = item.Height / scale };
                    if (i == listBoxVideoNo.SelectedIndex)
                    {
                        g.FillRectangle(new SolidBrush(Color.Gray), rect);
                        g.DrawRectangle(pens[i], rect);
                    }
                    else
                    {
                        g.DrawRectangle(pens[i], rect);
                    }

                    g.DrawLine(new Pen(new SolidBrush(Color.White)), new Point(rect.X - 5, rect.Y), new Point(rect.X + 5, rect.Y));
                    g.DrawLine(new Pen(new SolidBrush(Color.White)), new Point(rect.X, rect.Y - 5), new Point(rect.X, rect.Y + 5));
                }
                if (chkAuxiliaryLines.Checked)
                {
                    // 画十字线
                    g.DrawLine(new Pen(new SolidBrush(Color.White)), new Point(0, y), new Point(pnlContainer.Width, y));
                    g.DrawLine(new Pen(new SolidBrush(Color.White)), new Point(x, 0), new Point(x, pnlContainer.Height));

                }
            }
            var str = "电子白板屏";
            var ft = new Font("微软雅黑", 16);
            var sz = g.MeasureString(str, ft);
            var fx = (int)(pnlContainer.Width - sz.Width) / 2;
            var fy = (int)(pnlContainer.Height * (1- 0.618));
            g.DrawString(str, ft, new SolidBrush(Color.White), new Point(fx, fy));


            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            mgr.LoadConfig();
            listBoxSize.SelectedIndex = 0;
            listBoxVideoNo.SelectedIndex = 0;
            txtScale.Text = scale.ToString();
            pnlContainer.Invalidate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mgr.Save();
        }
        /// <summary>
        /// 摄像头变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxVideoNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 同步内存对象
            PictureInPuctureObject item = null;
            item = mgr.GetItemByvideoNo(listBoxVideoNo.SelectedIndex);
            if (item != null)
            {
                var s = $"{item.Width}X{item.Height}";
                for (var i = 0; i < listBoxSize.Items.Count; i++)
                {
                    if (listBoxSize.Items[i].ToString() == s)
                    {
                        listBoxSize.SelectedIndex = i;
                        break;
                    }
                }
                txtLeft.Text = item.Left.ToString();
                txtTop.Text = item.Top.ToString();
                txtWidth.Text = item.Width.ToString();
                txtHeight.Text = item.Height.ToString();
            }
            pnlContainer.Invalidate();
        }

        /// <summary>
        /// 画中画尺寸变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = listBoxSize.Items[listBoxSize.SelectedIndex].ToString();
            var param = s.Split('X');
            rectWidth = Convert.ToInt32(param[0]) / scale;
            rectHeight = Convert.ToInt32(param[1]) / scale;
            txtWidth.Text = param[0];
            txtHeight.Text = param[1];

            // 读取内存对象
            PictureInPuctureObject item = null;
            item = mgr.GetItemByvideoNo(listBoxVideoNo.SelectedIndex);
            if (item != null)
            {
                txtLeft.Text = item.Left.ToString();
                txtTop.Text = item.Top.ToString();

                item.Width = Convert.ToInt32(txtWidth.Text);
                item.Height = Convert.ToInt32(txtHeight.Text);
            }

            pnlContainer.Invalidate();
        }

        private void chkAuxiliaryLines_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAuxiliaryLines.Checked)
            {
                pnlContainer.Invalidate();
            }
        }
    }
}
