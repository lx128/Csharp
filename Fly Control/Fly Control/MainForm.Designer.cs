/*
 * Created by SharpDevelop.
 * User: User
 * Date: 12/09/2013
 * Time: 22:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Fly_Control
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Consigne = new System.Windows.Forms.VScrollBar();
			this.EtatActuel = new System.Windows.Forms.VScrollBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Contrainte = new System.Windows.Forms.VScrollBar();
			this.label4 = new System.Windows.Forms.Label();
			this.AngleVolet = new System.Windows.Forms.VScrollBar();
			this.Acceleration = new System.Windows.Forms.VScrollBar();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Consigne
			// 
			this.Consigne.Location = new System.Drawing.Point(46, 32);
			this.Consigne.Name = "Consigne";
			this.Consigne.Size = new System.Drawing.Size(17, 225);
			this.Consigne.TabIndex = 1;
			// 
			// EtatActuel
			// 
			this.EtatActuel.Location = new System.Drawing.Point(291, 32);
			this.EtatActuel.Name = "EtatActuel";
			this.EtatActuel.Size = new System.Drawing.Size(17, 225);
			this.EtatActuel.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Consigne";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(280, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Etat actuel";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(100, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Vent/Contrainte";
			// 
			// Contrainte
			// 
			this.Contrainte.Location = new System.Drawing.Point(127, 32);
			this.Contrainte.Name = "Contrainte";
			this.Contrainte.Size = new System.Drawing.Size(17, 225);
			this.Contrainte.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(341, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Angle volet";
			// 
			// AngleVolet
			// 
			this.AngleVolet.Location = new System.Drawing.Point(363, 32);
			this.AngleVolet.Name = "AngleVolet";
			this.AngleVolet.Size = new System.Drawing.Size(17, 225);
			this.AngleVolet.TabIndex = 8;
			// 
			// Acceleration
			// 
			this.Acceleration.Location = new System.Drawing.Point(214, 32);
			this.Acceleration.Name = "Acceleration";
			this.Acceleration.Size = new System.Drawing.Size(17, 225);
			this.Acceleration.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(193, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Acceleration";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 266);
			this.Controls.Add(this.Acceleration);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.AngleVolet);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Contrainte);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EtatActuel);
			this.Controls.Add(this.Consigne);
			this.Name = "MainForm";
			this.Text = "Fly Control";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.VScrollBar Acceleration;
		private System.Windows.Forms.VScrollBar AngleVolet;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.VScrollBar Contrainte;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.VScrollBar EtatActuel;
		private System.Windows.Forms.VScrollBar Consigne;
	}
}
