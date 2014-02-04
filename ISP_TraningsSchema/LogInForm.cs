/*
 * Created by SharpDevelop.
 * User: sys12eul
 * Date: 2014-02-03
 * Time: 13:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ISP_TraningsSchema
{
	/// <summary>
	/// Description of LogInForm.
	/// </summary>
	public partial class LogInForm : Form
	{
		public LogInForm()
		{
 

			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.getAll();
        }

		
	}
}
