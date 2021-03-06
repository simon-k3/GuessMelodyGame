﻿using System;
using System.Windows.Forms;

namespace GuessMelody
{
	public partial class FormMain : Form
	{
		FormPreferences formPreferences = new FormPreferences();

		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			GameData.ReadPreferences();
			GameData.ReadMusicList();
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonPreferences_Click(object sender, EventArgs e)
		{
			formPreferences.ShowDialog();
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			FormGame formGame = new FormGame();
			formGame.ShowDialog();
		}
	}
}
