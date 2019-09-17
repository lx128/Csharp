/*
 * Created by SharpDevelop.
 * User: User
 * Date: 13/03/2014
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Iban
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//13506100008510165200469
			char[] pays=new char[2];
			string iban;
			short comp,control;
			if (textBox1.Text.Length!=23)
			{
				MessageBox.Show("Longueur incorrecte. Le RIB doit faire 23 chiffres");
				label1.Text="RIB Incorrect";
				return;
			}
//			textBox1.Text.CopyTo(4,iban,0,19);
			/*if (ulong.Parse(textBox1.Text)==0)
			{
				MessageBox.Show("Pas de caractères. Le RIB doit faire 23 chiffres");
			}*/
			iban=textBox1.Text;
//			textBox1.Text.CopyTo(0,pays,0,4);
			pays[0]='f';
			pays[1]='r';
			for(comp=0;comp<2;comp++)
			{
				iban+=(pays[comp]-87).ToString();
			}
			iban+="00";
			control=(short)(98-(int)(System.Numerics.BigInteger.Parse(iban) % 97));
			label1.Text="FR"+control.ToString()+textBox1.Text;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//fr7613506100008510165200469
			char[] pays=new char[4];
			string ibantest;
			short comp;
			if (textBox1.Text.Length!=27)
			{
				MessageBox.Show("Longueur incorrecte. Le IBAN doit faire 27 chiffres");
				label1.Text="IBAN Incorrect";
				return;
			}
			ibantest=textBox1.Text.Substring(4,23);
			textBox1.Text.CopyTo(0,pays,0,4);
			for(comp=0;comp<2;comp++)
			{
				ibantest+=(pays[comp]-87).ToString();
			}
			ibantest+=textBox1.Text.Substring(2,2);
			if (System.Numerics.BigInteger.Parse(ibantest) % 97 == 1)
			{
				label1.Text="IBAN Valide";
			}
			else
			{
				label1.Text="IBAN Invalide";
			}
		}
	}
}
