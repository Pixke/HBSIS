﻿using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carrSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                DataGridViewExample.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex) {
                case 0: { this.carrosTableAdapter.DeleteQuery(carrSelect.Id); }break;
                case 1: {
                        frmEditarCarro editCar = new frmEditarCarro();
                        editCar.CarrosRow = carrSelect;
                        editCar.ShowDialog();

                        this.carrosTableAdapter.Update(carrSelect);


                    } break;
            }


            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Carros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Lixeira tela = new Lixeira();
            tela.ShowDialog();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();

            this.carrosTableAdapter.Insert(
                formAdd.carrosRow.Modelo,
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );

            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
        }
    }
}
