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
    public partial class FormRedisInput : Form
    {
        public FormRedisInput( RedisClient redis )
        {
            InitializeComponent( );
            this.redis = redis;
        }

        private RedisClient redis;

        private void FormRedisInput_Load( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty( textBox1.Text ))
            {
                MessageBox.Show( "Key Can not be null" );
            }
            else
            {
                OperateResult write = redis.WriteKey( textBox1.Text, textBox2.Text );
                if (write.IsSuccess)
                {
                    MessageBox.Show( "Write sucess" );
                }
                else
                {
                    MessageBox.Show( "Failed:" + write.Message );
                }
            }
        }

        private void button2_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty( textBox4.Text ) || string.IsNullOrEmpty( textBox5.Text ))
            {
                MessageBox.Show( "Key Can not be null" );
            }
            else
            {
                OperateResult write = redis.WriteHashKey( textBox4.Text, textBox5.Text, textBox3.Text );
                if (write.IsSuccess)
                {
                    MessageBox.Show( "Write sucess" );
                }
                else
                {
                    MessageBox.Show( "Failed:" + write.Message );
                }
            }
        }

        private void button3_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrEmpty( textBox6.Text ) || string.IsNullOrEmpty( textBox7.Text ))
            {
                MessageBox.Show( "Key Can not be null" );
            }
            else
            {
                OperateResult write = null;
                if (radioButton2.Checked)
                {
                    write = redis.ListRightPush( textBox7.Text, textBox6.Text );
                }
                else
                {
                    write = redis.ListLeftPush( textBox7.Text, textBox6.Text );
                }
                
                if (write.IsSuccess)
                {
                    MessageBox.Show( "Write sucess" );
                }
                else
                {
                    MessageBox.Show( "Failed:" + write.Message );
                }
            }
        }

        private void button4_Click( object sender, EventArgs e )
        {
            // 集合写入
            if (string.IsNullOrEmpty( textBox9.Text ))
            {
                MessageBox.Show( "Key Can not be null" );
            }
            else
            {
                OperateResult write = null;
                write = redis.SetAdd( textBox9.Text, textBox8.Text );

                if (write.IsSuccess)
                {
                    MessageBox.Show( "Write sucess" );
                }
                else
                {
                    MessageBox.Show( "Failed:" + write.Message );
                }
            }
        }

        private void button5_Click( object sender, EventArgs e )
        {
            // 有序集合写入
            if (string.IsNullOrEmpty( textBox11.Text ))
            {
                MessageBox.Show( "Key Can not be null" );
            }
            else
            {
                if(!double.TryParse(textBox12.Text, out double score ))
                {
                    MessageBox.Show( "得分信息输入失败！" );
                    return;
                }

                OperateResult write = null;
                write = redis.ZSetAdd( textBox11.Text, textBox10.Text, score );

                if (write.IsSuccess)
                {
                    MessageBox.Show( "Write sucess" );
                }
                else
                {
                    MessageBox.Show( "Failed:" + write.Message );
                }
            }
        }
    }
}
