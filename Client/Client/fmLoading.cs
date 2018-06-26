using ClientManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class FmLoading : Form
    {
        public FmLogin fmLogin = null;
        public FmLoading()
        {
            InitializeComponent();
        }

        private void FmLoading_Load(object sender, EventArgs e)
        {
            new Action(() =>
            {
                Thread.Sleep(1000);
            }
            ).BeginInvoke(new AsyncCallback(
                delegate(IAsyncResult iAsyncResult)
                {
                    if (iAsyncResult.IsCompleted)
                    {
                        Invoke(new Action(() =>
                        {
                            this.Close();
                            fmLogin = new FmLogin();
                        }
                            ));
                    }
                }), null);
        }

        protected override void OnResize(System.EventArgs e)
        {
            this.Region = null;
            new SetWindowRegion(this);
        }
    }
}
