/*
 * Created by SharpDevelop.
 * User: User
 * Date: 12/09/2013
 * Time: 22:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fly_Control
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Timer tic = new Timer();
		int a,EtatPrécédent,Correction,correction_maxi_admissible, angle_idéal, inertie;
		bool fin_correction;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

			tic.Interval=100;
			tic.Tick += new EventHandler(NouvelleConsigne);
			tic.Start();

			Consigne.Value=50;
			Acceleration.Value=1;
			Contrainte.Value=5;
			correction_maxi_admissible=5;
			EtatPrécédent=0;
			fin_correction=false;
			inertie=3;
		}
		private void NouvelleConsigne(object source, EventArgs e)
		{
			//simulation de l'état
			EtatPrécédent=EtatActuel.Value;
			a=EtatActuel.Value+((AngleVolet.Value-50)*Acceleration.Value)+Contrainte.Value;
			if (a>100){a=100;}
			if (a<0){a=0;}
			EtatActuel.Value=a;
			//fin simultaion

			//phase de correction
			if (Math.Abs(Consigne.Value-EtatActuel.Value)>inertie)
			{
				a=Math.Abs(EtatPrécédent-EtatActuel.Value);//dernier effet
				//test des conséquences de la correction
				if (a<correction_maxi_admissible)//correction trop faible
				{
					angle_idéal+=1;
				}
				else if (a>correction_maxi_admissible)//correction trop forte
				{
					angle_idéal-=1;
				}
				//sinon ne rien changer
		
				if (EtatActuel.Value< Consigne.Value)
				{
					Correction=1;
				}
				else if (EtatActuel.Value> Consigne.Value)
				{
					Correction=-1;
				}
				else
				{
					
				}
			}
			else//fin de correction
			{
				Correction=-AngleVolet.Value+50;//volet au milieu
			}

			a=AngleVolet.Value+Correction;
			if (a>100){a=100;}
			if (a<0){a=0;}
			AngleVolet.Value=a;
		}
	}
}
