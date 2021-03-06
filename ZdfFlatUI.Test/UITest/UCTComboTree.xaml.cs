﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZdfFlatUI.Test.Model;

namespace ZdfFlatUI.Test.UITest
{
    /// <summary>
    /// UCTComboTree.xaml 的交互逻辑
    /// </summary>
    public partial class UCTComboTree : UserControl
    {
        public UCTComboTree()
        {
            InitializeComponent();

            ObservableCollection<Dept> datas = new ObservableCollection<Dept>();

            for (int i = 0; i < 10; i++)
            {
                Dept dept = new Dept();
                dept.ID = i.ToString();
                dept.Name = "第一级" + i;
                if (i % 2 == 0)
                {
                    dept.Children = new ObservableCollection<Dept>();
                    for (int j = 0; j < 5; j++)
                    {
                        Dept child = new Dept();
                        child.ID = i.ToString() + j.ToString();
                        child.Name = "第二级" + i.ToString() + j.ToString();

                        if (j % 2 == 0)
                        {
                            child.Children = new ObservableCollection<Dept>();
                            for (int k = 0; k < 2; k++)
                            {
                                Dept three = new Dept();
                                three.ID = i.ToString() + j.ToString() + k.ToString();
                                three.Name = "第二级" + i.ToString() + j.ToString() + k.ToString();
                                child.Children.Add(three);
                            }
                        }

                        dept.Children.Add(child);
                    }
                }

                datas.Add(dept);
            }
            
            this.comboTree.ItemsSource = datas;
            this.comboTree.DisplayMemberPath = "Name";
            this.comboTree.SelectedValuePath = "ID";
            this.comboTree.SelectedValue = "201";

            this.comboTree2.ItemsSource = datas;
            this.comboTree2.DisplayMemberPath = "Name";
            this.comboTree2.SelectedValuePath = "ID";
            this.comboTree2.SelectedValue = "201";
        }
    }
}
