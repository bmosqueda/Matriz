using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class Form1 : Form
    {
        public class Matriz
        {
            private int[,] matriz;
            private int filas;
            private int columnas;
            public int Filas { get { return filas; } }
            public int Columnas { get { return columnas; } }

            public Matriz(int filas, int columnas)
            {
                matriz = new int[filas, columnas];
                this.filas = filas;
                this.columnas = columnas;
            }

            public void llenar()
            {
                int cont = 1;
                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < columnas; j++, cont++)
                        matriz[i, j] = cont;
            }

            public void llenarColumnas()
            {
                int cont = 1;
                for (int i = 0; i < columnas; i++)
                    for (int j = 0; j < filas; j++, cont++)
                        matriz[j, i] = cont;
            }

            public void llenarInverso()
            {
                int cont = 1;
                for (int i = filas - 1; i >= 0; i--)
                    for (int j = columnas - 1; j >= 0; j--, cont++)
                        matriz[i, j] = cont;
            }

            public string mostrar()
            {
                string matrizString = "";
                for(int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        matrizString += matriz[i, j];
                        matrizString += matriz[i, j] > 9 ? "  " : "     ";
                    }
                    matrizString += "\n";
                }

                return matrizString;
            }

            public string diagonalPrincipal()
            {
                string diagonal = "";
                for (int i = 0; i < filas; i++)
                    diagonal += matriz[i, i] + "  ";

                return diagonal;
            }

            public string diagonalSecundaria()
            {
                string diagonal = "";
                int columnaTemp = columnas - 1;
                for(int i = 0; i < filas; i++, columnaTemp--)
                {
                    diagonal += matriz[i, columnaTemp] + "    ";
                }

                return diagonal;
            }

            public string trianguloArribaSecundaria()
            {
                string triangulo = "";
                for(int i = 0; i < filas - 1; i++)
                {
                    for(int j = 0; j <= columnas - 2 - i; j++)
                    {
                        triangulo += matriz[i, j];
                        triangulo += matriz[i, j] > 9 ? "  " : "     ";
                    }

                    triangulo += "\n";
                }

                return triangulo;
            }

            public string trianguloAbajoPrincipal()
            {
                string triangulo = "";
                for(int i = 1; i < filas; i++)
                {
                    for(int j = 0; j < i; j++)
                    {
                        triangulo += matriz[i, j];
                        triangulo += matriz[i, j] > 9 ? "  " : "     ";
                    }

                    triangulo += "\n";
                }
                return triangulo;
            }

            public void invertirPorDiagonalPrincipal()
            {
                for (int i = 1; i < filas; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (i == j)
                            continue;
                        else
                        {
                            int temp = matriz[i, j];
                            matriz[i, j] = matriz[j, i];
                            matriz[j, i] = temp;
                        }
                    }
                }
            }

            public void invertirPorDiagonalSecundaria()
            {
                int columnaTemp = columnas - 1;
                int filaTemp = filas - 1;
                for (int i = 0; i < filas; i++, columnaTemp--)
                {
                    filaTemp = filas - 1;
                    for (int j = 0; j < columnas - 1 - i; j++, filaTemp--)
                    {
                        int temp = matriz[i, j];
                        matriz[i, j] = matriz[filaTemp, columnaTemp];
                        matriz[filaTemp, columnaTemp] = temp;
                    }
                }
            }
        }


        Matriz matriz;
        public Form1()
        {
            InitializeComponent();
            matriz = new Matriz(5, 5);
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            matriz.llenar();
            MessageBox.Show("Llenada");
        }

        private void btnLlenarColumnas_Click(object sender, EventArgs e)
        {
            matriz.llenarColumnas();
            MessageBox.Show("Llenada por columnas");
        }

        private void btnLlenarInverso_Click(object sender, EventArgs e)
        {
            matriz.llenarInverso();
            MessageBox.Show("LLenado inverso");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = matriz.mostrar();
        }

        private void btnDiagonalPrincipal_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = matriz.diagonalPrincipal();
        }

        private void btnDiagonalSecundaria_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = matriz.diagonalSecundaria();
        }

        private void btnTrianguloBajoPrincipal_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = matriz.trianguloAbajoPrincipal();
        }

        private void btnTrianguloArribaSecundaria_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = matriz.trianguloArribaSecundaria();
        }

        private void btnInvertirDiagonalPrincipal_Click(object sender, EventArgs e)
        {
            matriz.invertirPorDiagonalPrincipal();
        }

        private void btnInvertirPorSecundaria_Click(object sender, EventArgs e)
        {
            matriz.invertirPorDiagonalSecundaria();
        }
    }
}
