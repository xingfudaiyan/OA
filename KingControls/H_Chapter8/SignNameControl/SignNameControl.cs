using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace KingControls
{
    /// <summary>
    /// Author: 【夜战鹰】【专注于DotNet技术】【ChengKing(ZhengJian)】
    /// 获得本书的更多章节:【http://blog.csdn.net/ChengKing/archive/2008/08/18/2792440.aspx】
    /// 声明: 【本链接为进阶Asp.net技术的一些文章】【转载时请保留本链接源】
    /// </summary>
    [ToolboxData("<{0}:SignNameControl runat=server></{0}:SignNameControl>")]
    public class SignNameControl : CompositeControl, IPostBackEventHandler
    {
        private const int MM_ANISOTROPIC = 8;

        public enum PenSizeEnum
        {
            Normal = 1,
            Bold = 2
        }

        public enum DisplayModeEnum
        {
            Edit = 1,
            View = 2
        }

        private enum EmfToWmfBitsFlags
        {
            EmfToWmfBitsFlagsDefault = 0x00000000,
            EmfToWmfBitsFlagsEmbedEmf = 0x00000001,
            EmfToWmfBitsFlagsIncludePlaceable = 0x00000002,
            EmfToWmfBitsFlagsNoXORClip = 0x00000004
        }

        private string _signatureHex = string.Empty;
        private string _signatureCoordinate = string.Empty;
        private int _signatureWidth = 400;
        private int _signatureHeight = 120;
        private PenSizeEnum _penSize = PenSizeEnum.Normal;
        private DisplayModeEnum _mode = DisplayModeEnum.View;

        public string SignatureCoordinate
        {
            get
            {
                this.EnsureChildControls();
                return itemTracker.Value.ToString();
            }
            set
            {
                this.EnsureChildControls();
                itemTracker.Value = value;
            }
        }

        public int SignatureWidth
        {
            get
            {
                return _signatureWidth;
            }
            set
            {
                _signatureWidth = value;
            }

        }

        public int SignatureHeight
        {
            get
            {
                return _signatureHeight;
            }
            set
            {
                _signatureHeight = value;
            }

        }

        public PenSizeEnum PenSize
        {
            get
            {
                object o = ViewState["PenSize"];
                return (o != null) ? (PenSizeEnum)o : PenSizeEnum.Normal;
            }
            set
            {
                ViewState["PenSize"] = value;
            }

        }

        public string SignatureHex
        {
            get
            {
                return convertCoordinatesToHex();
            }
            set
            {
                _signatureHex = value;
                this.Page.Session["SaveValueHex"] = value;
            }
        }

        public DisplayModeEnum DisplayMode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        public string ClientPath
        {
            get
            {
                string p = (string)ViewState["ClientPath"];
                return ((p == null) ? String.Empty : p);
            }
            set
            {
                ViewState["ClientPath"] = value;
            }
        }

        public string ButtonClass
        {
            get
            {
                string p = (string)ViewState["ButtonClass"];
                return ((p == null) ? String.Empty : p);
            }
            set
            {
                ViewState["ButtonClass"] = value;
            }
        }

        private HtmlInputHidden itemTracker;



        [DllImportAttribute("gdiplus.dll")]
        private static extern uint GdipEmfToWmfBits(IntPtr _hEmf, uint _bufferSize, byte[] _buffer, int _mappingMode, EmfToWmfBitsFlags _flags);


        public SignNameControl()
        {
            this.ClientPath = @"KingControls";
        }

        private string convertCoordinatesToHex()
        {
            string signatureHex = string.Empty;

            if (SignatureCoordinate.Length > 0)
            {
                StringBuilder signatureHexVaule = new StringBuilder();
                MemoryStream memoryStream = new MemoryStream();
                System.Drawing.Image signatureTemplateImg = new System.Drawing.Bitmap(SignatureWidth, SignatureHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Graphics SignatureGraphs = Graphics.FromImage(signatureTemplateImg);
                SignatureGraphs.FillRectangle(Brushes.White, 0, 0, signatureTemplateImg.Width, signatureTemplateImg.Height);

                Metafile signatureMetaFile = null;
                IntPtr hdc;
                try
                {
                    using (SignatureGraphs = Graphics.FromImage(signatureTemplateImg))
                    {
                        hdc = SignatureGraphs.GetHdc();
                        signatureMetaFile = new Metafile(memoryStream, hdc);
                        SignatureGraphs.ReleaseHdc(hdc);
                    }
                    using (SignatureGraphs = Graphics.FromImage(signatureMetaFile))
                    {
                        SignatureGraphs.DrawImage(signatureTemplateImg, new System.Drawing.Rectangle(0, 0, signatureTemplateImg.Width, signatureTemplateImg.Height));
                        SignatureGraphs.DrawRectangle(new Pen(Color.White, 1), 0, 0, SignatureWidth, SignatureHeight);

                        Pen pen = new Pen(Color.Black, 1);
                        string[] points = SignatureCoordinate.Split(':');
                        string[] point = null;

                        for (int i = 0; i < points.Length - 1; i++)
                        {
                            point = points[i].Split('~');
                            if (point.Length == 4)
                            {
                                SignatureGraphs.DrawRectangle(pen, float.Parse(point[0]), float.Parse(point[1]), float.Parse(point[2]), float.Parse(point[3]));
                            }
                        }
                    }

                    IntPtr hEmf = signatureMetaFile.GetHenhmetafile();

                    uint bufferSize = GdipEmfToWmfBits(hEmf, 0, null, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);
                    byte[] buffer = new byte[bufferSize];

                    GdipEmfToWmfBits(hEmf, bufferSize, buffer, MM_ANISOTROPIC, EmfToWmfBitsFlags.EmfToWmfBitsFlagsDefault);

                    for (int i = 0; i < buffer.Length; ++i)
                    {
                        signatureHexVaule.Append(String.Format("{0:X2}", buffer[i]));
                    }

                    signatureHex = signatureHexVaule.ToString();
                }
                finally
                {
                    if (SignatureGraphs != null)
                    {
                        SignatureGraphs.Dispose();
                    }

                    if (signatureMetaFile != null)
                    {
                        signatureMetaFile.Dispose();
                    }

                    if (memoryStream != null)
                    {
                        memoryStream.Close();
                    }
                }
            }

            return signatureHex;
        }


        protected override void CreateChildControls()
        {
            itemTracker = new HtmlInputHidden();
            itemTracker.ID = "itemTracker";
            itemTracker.EnableViewState = false;
            Controls.Add(itemTracker);
            base.CreateChildControls();

        }

        protected override void OnPreRender(EventArgs e)
        {
            string strJScript = base.ResolveUrl(Path.Combine(this.ClientPath, @"Js\SignatureCapture.js"));
            if (!Page.ClientScript.IsClientScriptBlockRegistered(this.GetType(), "SignName"))
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "SignName",
                    "<script type='text/javascript' src='" + strJScript + "'></script>", false);
            }

            //OR
            //if (!Page.ClientScript.IsClientScriptIncludeRegistered(this.GetType(), "SignName"))
            //{
            //    Page.ClientScript.RegisterClientScriptInclude(this.GetType(), "SignName",
            //        strJScript);
            //}


            StringBuilder strInitScript = new StringBuilder();
            strInitScript.Append(" window.onload = initialize;");
            strInitScript.Append(" function initialize(){");
            strInitScript.Append(" load('" + itemTracker.ClientID + "');}");

            if (!Page.ClientScript.IsStartupScriptRegistered(this.GetType(), "InitScript" + this.ClientID))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "InitScript" + this.ClientID,
                    strInitScript.ToString(), true);
            }
            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            if (this._mode == DisplayModeEnum.Edit)
            {
                writer.Write("<style type=\"text/css\">");
                writer.Write("  .point {position: absolute; background-color: black; color: black; width: 1px; height: 1px;font-size: " + Convert.ToInt16(_penSize) * 2 + "px}");
                writer.Write("</style>");
                writer.Write("<table border=\"1\" cellpadding=\"0\" class=\"{0}\" cellspacing=\"10\" ID=\"Panel\">", this.CssClass);
                writer.Write("  <tr>");
                writer.Write("     <td colspan=4 height=\"40\" width=\"120\">");
                writer.Write("         <div id=\"Canvas\" style=\"background-color: white; width: " + _signatureWidth + "px; height: " + _signatureHeight + "px\"></div>");
                writer.Write("     </td>");
                writer.Write("   </tr>");

                writer.Write("   <tr> ");
                writer.Write("     <td width=30px></td> ");
                writer.Write("     <td style='border:0; text-align:center;' width='30'><input onclick=\"{0}\" class=\"{1}\" type='button' value='保存' name='Save'></td>", "captureSignature();" + Page.ClientScript.GetPostBackEventReference(this, "SaveClick"), this.ButtonClass);
                writer.Write("     <td style='border:0; text-align:center;' width='30'><input id='BtnClearSignature' type='button' value='放弃' name='Clear' onclick=\"{0}\" class=\"{1}\"></td>", Page.ClientScript.GetPostBackEventReference(this, "ClearClick"), this.ButtonClass);
                writer.Write("     <td style='border:0; text-align:center;' width='30'><input  class=\"{0}\" onclick='clearSignature()' type='button' value='清空写字板' name='Clear'>&nbsp;&nbsp;</td>", this.ButtonClass);
                writer.Write("   </tr> ");
                writer.Write("</table>");

            }
            else
            {
                writer.Write("<table class=\"{0}\">", this.CssClass);
                writer.Write("  <tr>");
                writer.Write("      <td>");
                writer.Write("          <table cellSpacing='10' cellPadding='0' border='1'>");
                writer.Write("              <tr>");
                writer.Write("                  <td colspan=3>");
                if (this.DesignMode)
                {
                    string strPicPath = base.ResolveUrl(Path.Combine(this.ClientPath, @"Images\SignName.jpg"));
                    writer.Write("                      <img src ='" + strPicPath + "'" + " width=" + _signatureWidth + " height=" + _signatureHeight + " />");
                }
                else
                {
                    writer.Write("                      <img src ='DisplayImage.aspx'" + " width=" + _signatureWidth + " height=" + _signatureHeight + " />");
                }
                writer.Write("                  </td>");
                writer.Write("              </tr>");

                writer.Write("              <tr>");
                writer.Write("                  <td width='300'></td>");
                writer.Write("                  <td style='border:0; text-align:center;' width=''><input onclick=\"{0}\" class=\"{1}\" type='button' value='编辑' name='Edit'></td>", Page.ClientScript.GetPostBackEventReference(this, "EditClick"), this.ButtonClass);
                writer.Write("                  <td style='border:0; text-align:center;' width=''><input onclick=\"{0}\" class=\"{1}\" type='button' value='刷新' name='Refresh'>&nbsp;</td>", Page.ClientScript.GetPostBackEventReference(this, "RefreshClick"), this.ButtonClass);
                writer.Write("              </tr>");

                writer.Write("          </table>");
                writer.Write("      </td>");
                writer.Write("  </tr>");

                writer.Write("</table>");

            }
            base.Render(writer);
        }



        private static readonly object ClearClickObject = new object();
        public event EventHandler ClearClick
        {
            add
            {
                base.Events.AddHandler(ClearClickObject, value);
            }
            remove
            {
                base.Events.RemoveHandler(ClearClickObject, value);
            }
        }
        protected virtual void OnClearClick(EventArgs e)
        {
            EventHandler ClearClickHandler = (EventHandler)Events[ClearClickObject];
            if (ClearClickHandler != null)
            {
                ClearClickHandler(this, e);
                this.Page.Session.Remove("SaveValueHex");
            }
        }

        private static readonly object SaveClickObject = new object();
        public event DataEventHandler SaveClick
        {
            add
            {
                base.Events.AddHandler(SaveClickObject, value);
            }
            remove
            {
                base.Events.RemoveHandler(SaveClickObject, value);
            }
        }
        protected virtual void OnSaveClick(DataEventArgs e)
        {
            DataEventHandler SaveClickHandler = (DataEventHandler)Events[SaveClickObject];
            if (SaveClickHandler != null)
            {
                e.DataValue = this.SignatureHex;
                this.Page.Session["SaveValueHex"] = e.DataValue;
                SaveClickHandler(this, e);
            }
        }


        public void RaisePostBackEvent(string eventArgument)
        {
            switch (eventArgument)
            {
                case "ClearClick": OnClearClick(EventArgs.Empty); this.DisplayMode = DisplayModeEnum.View; break;
                case "SaveClick": OnSaveClick(new DataEventArgs()); this.DisplayMode = DisplayModeEnum.View; break;
                case "EditClick": this.DisplayMode = DisplayModeEnum.Edit; break;
                case "RefreshClick": this.DisplayMode = DisplayModeEnum.View; break;
            }
        }
    }
}
