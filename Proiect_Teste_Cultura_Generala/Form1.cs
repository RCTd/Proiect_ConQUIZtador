﻿using Proiect_Teste_Cultura_Generala;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace UIProiectIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-8LL5B1N\SQLEXPRESS;Initial Catalog=ProiectIP;Integrated Security=True");


        private void button_Start(object sender, EventArgs e)
        {
            /*
            String username, parola;
            username = txt_username.Text;
            parola=txt_parola.Text;
            try
            {
                String querry ="SELECT * FROM Login_pass WHERE username = '"+txt_username.Text+"' AND parola = '"+txt_parola.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, _conn);
                DataTable dtable=new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0 )
                {
                    username = txt_username.Text;
                    parola = txt_parola.Text;

                    //incarca formul urmator
                    //Map form2 = new Map();
                    //form2.Show();
                    //this.Hide();*/
                    Map mod = new Map();
                    mod.Owner = this;
                    mod.Show();
                    this.Hide();
            /*
                }
                else
                {
                    MessageBox.Show("Parola sau Username gresite sau nu ai cont");
                    //txt_username.Clear();
                    //txt_parola.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Eroare, contactati administratorul");
            }
            finally
            {
                _conn.Close();
            }
            */
            
        }

        private void buttonSingUp_Click(object sender, EventArgs e)
        {/*
            try
            {
                String InsertQuerry = "Insert into Login_pass(username,parola)Values('" + txt_username.Text + "','" + txt_parola.Text + "')";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(InsertQuerry, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
                MessageBox.Show("Contul a fost facut, acum poti da START");
            }
            catch(SqlException ex) when (ex.Number == 2627)
            {
               MessageBox.Show("Acest username nu este valabil, incercati altul! ");
               

            }
            finally
            {
                _conn.Close();
            }
            */
        }

        private void buttonHelp(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../Resources/Conquistador.chm");
        }

        private void button_Scor(object sender, EventArgs e)
        {

        }
    }

}
