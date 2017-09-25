/*
 * Сделано в SharpDevelop.
 * Пользователь: suvoroda
 * Дата: 06/03/2015
 * Время: 17:25
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Astronomics
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
			InitializeLisiOuterBodies();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		List<Planet> PlanetCollection = new List<Planet>();
		List<Star> StarCollection = new List<Star>();
		
		void AddOuterBodyClick(object sender, EventArgs e)
		{
			if (TypeBodyF.SelectedIndex == 0)
				AddPlanet();
			else if (TypeBodyF.SelectedIndex == 1)
				AddStar();
		}
		
		private void InitializeLisiOuterBodies()
		{			
	        ListOuterBody.ColumnCount = 6;
	        ListOuterBody.Columns[0].Name = "Тип космического объекта";
	        ListOuterBody.Columns[1].Name = "Имя космического объекта";
	        ListOuterBody.Columns[2].Name = "Радиус космического объекта";
	        ListOuterBody.Columns[3].Name = "Масса космического объекта";
	        ListOuterBody.Columns[4].Name = "Скорость вращения космического объекта";
	        ListOuterBody.Columns[5].Name = "Планета - вращение вокруг зезды/Звезда - светимость";
		}
		
		void AddPlanet ()
		{
			PlanetCollection.Add(new Planet(NameBodyF.Text, 
			                                Convert.ToDouble(RadiusBodyF.Text),
			                                Convert.ToDouble(MassaBodyF.Text),
			                                Convert.ToDouble(SpeedRotationF.Text),
			                                Convert.ToDouble(ChangedF.Text)));
			ListOuterBody.Rows.Add(new object[]{"Планета",NameBodyF.Text,RadiusBodyF.Text,MassaBodyF.Text,SpeedRotationF.Text,ChangedF.Text});
		}
		
		void AddStar ()
		{
			StarCollection.Add(new Star(NameBodyF.Text, 
			                                Convert.ToDouble(RadiusBodyF.Text),
			                                Convert.ToDouble(MassaBodyF.Text),
			                                Convert.ToDouble(SpeedRotationF.Text),
			                                Convert.ToDouble(ChangedF.Text)));
			ListOuterBody.Rows.Add(new object[]{"Звезда",NameBodyF.Text,RadiusBodyF.Text,MassaBodyF.Text,SpeedRotationF.Text,ChangedF.Text});
		}
		
			
		void RadiusBodyFTextChanged(object sender, EventArgs e)
		{			
			try
			{
				double res;
				if(!double.TryParse(((MaskedTextBox)sender).Text, out res))
					throw new System.Exception();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Не корректное число!");
				((MaskedTextBox)sender).Text = "";
			}
		}
		
		void MassaBodyFTextChanged(object sender, EventArgs e)
		{
			try
			{
				double res;
				if(!double.TryParse(((MaskedTextBox)sender).Text, out res))
					throw new System.Exception();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Не корректное число!");
				((MaskedTextBox)sender).Text = "";
			}
		}
		
		void SpeedRotationFTextChanged(object sender, EventArgs e)
		{
			try
			{
				double res;
				if(!double.TryParse(((MaskedTextBox)sender).Text, out res))
					throw new System.Exception();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Не корректное число!");
				((MaskedTextBox)sender).Text = "";
			}
		}
		
		void ChangedFTextChanged(object sender, EventArgs e)
		{
			try
			{
				double res;
				if(!double.TryParse(((MaskedTextBox)sender).Text, out res))
					throw new System.Exception();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Не корректное число!");
				((MaskedTextBox)sender).Text = "";
			}
		}
	}
}
