﻿using LQClass.CustomControls.TabControlHelper;
using System.Windows.Controls;
using WpfExtensions.Xaml;

namespace LQClass.ModuleOfGroupManagement.Views
{
	/// <summary>
	/// Interaction logic for ViewA.xaml
	/// </summary>
	public partial class MainTabItemView : UserControl, ICloseable
	{
		public MainTabItemView()
		{
			InitializeComponent();
			this.Closer = new CloseableHeader(ModuleOfGroupManagementModule.KEY_OF_CURRENT_MODULE, I18nManager.Instance.Get(I18nResources.Language.MainTabItemView_Header).ToString(), true);
		}

		public CloseableHeader Closer { get; private set; }
	}
}
