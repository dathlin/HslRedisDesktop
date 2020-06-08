﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication.Enthernet.Redis;
using HslCommunication;

namespace HslRedisDesktop
{
    public partial class ListValueEditForm : Form
    {
        public ListValueEditForm( RedisSettings settings, string key, int index, string value )
        {
            InitializeComponent( );
            this.redisSettings = settings;
            this.key = key;
            this.index = index;
            this.value = value;
        }

        private void StringValueEditForm_Load( object sender, EventArgs e )
        {
            textBox1.Text = $"{this.redisSettings.Name}[{this.redisSettings.IpAddress}:{this.redisSettings.Port}]";
            textBox2.Text = this.key;
            textBox3.Text = this.value;
            textBox4.Text = this.redisSettings.DBBlock.ToString( );
            textBox5.Text = this.index.ToString( );

            Icon = Icon.FromHandle( Properties.Resources.brackets_Square_16xMD.GetHicon( ) );
            ListValueEditForm_SizeChanged( null, null );
        }


        private RedisSettings redisSettings = null;               // Redis的配置信息
        private string key = string.Empty;                        // 等待编辑的键信息
        private int index = -1;                                   // 列表的索引位置
        private string value = string.Empty;                      // 等待编辑的文字信息

        private void button1_Click( object sender, EventArgs e )
        {
            OperateResult write = this.redisSettings.Redis.ListSet( this.key, this.index, textBox3.Text );
            if(write.IsSuccess)
            {
                MessageBox.Show( "列表数据写入成功！" );
            }
            else
            {
                MessageBox.Show( "列表数据写入失败！" + write.Message );
            }
        }

        private void StringValueEditForm_Shown( object sender, EventArgs e )
        {
            textBox3.Focus( );
        }

        private void ListValueEditForm_SizeChanged( object sender, EventArgs e )
        {
            button1.Location = new Point( this.Width / 2 - button1.Width / 2, this.Height - 100 );
        }
    }
}
