using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace so
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            int ancho = 77;
                tblprocesamiento.Columns[0].Width=ancho;
                tblprocesamiento.Columns[1].Width = ancho;
                tblprocesamiento.Columns[2].Width = ancho;
                tblprocesamiento.Columns[3].Width = ancho;
                tblprocesamiento.Columns[4].Width = ancho;
                tblprocesamiento.Columns[5].Width = ancho;
                tblprocesamiento.Columns[6].Width = ancho;
                tblprocesamiento.Columns[7].Width = ancho;
                tblprocesamiento.Columns[8].Width = ancho;
                tblprocesamiento.Columns[9].Width = ancho;           

            tblprocesamiento.Rows.Add(100);
            estado();
        }
        escritura s = new escritura();
        //Asignacion de color a cada proceso, de acuerdo a un random
        public String asignacion_color()
        {
            String color=null;
            
            Random aleatorio=new Random();

            int valor = aleatorio.Next(1, 9);
            switch (valor)
            {
                case 1:
                    color = "beige";
                    break;
                case 2:
                    color = "blue";
                    break;
                case 3:
                    color = "yellow";
                    break;
                case 4:
                    color = "brown";
                    break;
                case 5:
                    
                    color="green";
                    break;
                case 6:
                    color = "gray";
                    break;
                case 7:
                    color = "orange";
                    break;
                case 8:

                    color = "red";
                    break;
                case 9:
                    color = "violet";
                    break;                
            }
            return color;
        }
        public void estado() //METODO QUE VALIDA EL CHEKS PARA MODIFICAR EL QUANTUM
        {
            if (ck_estado.CheckState == 0)
            {
                txtquantum.Enabled = false;
                txtquantum.Text=Convert.ToString(trakbarra.Value);
                trakbarra.Enabled = true;
            }
            else
            {
                txtquantum.Enabled = true;
                trakbarra.Enabled = false;
                trakbarra.Value = Convert.ToInt32(txtquantum.Text);
            }
        }

        private void ck_estado_CheckedChanged(object sender, EventArgs e) //Llama al metodo de estado para el chek
        {
            estado();
        }

        //METODO que agrega NOMBRE, CANTIDAD Y COLOR requerida para la lista de procesos
        private void btnagregar_Click(object sender, EventArgs e)                                                                   
        {
            String nomproceso=txtproceso.Text;            
            String cpu=txtrequerimiento.Text;
            String color = asignacion_color();//llama al metodo asignacion color (return color), retorna un valor string para asignar a la variable color
            if((nomproceso=="")||(cpu==""))
            {
                MessageBox.Show("Debe llenar todos los Datos");
            }
            else{
                tblprocesos.Rows.Add(nomproceso, cpu, color);
                txtproceso.Text = "";
                txtrequerimiento.Text = "";
            }
            
            
        }

        //RECIBE EL VALOR DE QUANTUM DE LA BARRA DE DE LA TRACKBARRA
        private void trakbarra_Scroll(object sender, EventArgs e)
        {
            
            txtquantum.Text = Convert.ToString(trakbarra.Value);
        }

        //RECIBE CUANTAS FILAS CONTIENE LA TABLA PROCESOS
        public int fiprocesos()
        {
            int filas = tblprocesos.RowCount;
            return filas;
        }

        //RECIBE CUANTAS COLUMNAS TIENE LA TABLA PROCESOS
        public int colprocesos()
        {
            int col = tblprocesos.ColumnCount;
            return col;
        }
        //RECIBE CUANTAS FILAS CONTIENE LA TABLA DE PLANIFICACION
        public int fiprocesamiento()
        {
            int fil = tblprocesamiento.RowCount;
            return fil;
        }
        //RECIBE CUANTAS COLUMNAS CONTIENE LA TABLA DE PLANIFICACION
        public int colprocesamiento()
        {
            int col = tblprocesamiento.ColumnCount;
            return col;
        }
        
        //METODO QUE SE USA PARA PINTAR LAS CELDAS EN LA TABLA PLANIFICACION
        public void pintar(String color, int x, int y,DataGridView tabla) //metodo que pinta las celdas de acuerdo a las posiciones
        {
            Color col = Color.FromName(color);//le asignamos un color de acuerdo al parametro
            tabla.Rows[x].Cells[y].Style.BackColor = col; //pintar celdas de acuerdo al color
            //----------------------------------------------------------------
            tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;            
         
            switch(color) //de acuerdo si un color de un proceso esta dentro del case, colorea las celdas con una fuente diferente
            {
                case "red":
                case "black":
                case "blue":
                case "orange":
                case "violet":
                case "brown":
                case "green":
                case "gray":
                    tabla.DefaultCellStyle.ForeColor = Color.White;
                    //tabla.ForeColor = Color.White;
                    break;
                default:
                    //tabla.ForeColor = Color.Black;
                    tabla.DefaultCellStyle.ForeColor = Color.Black;
                    break;
            }
        }
        //METOD QUE SE USA PARA ESCRIBIR EN LA TABLA DE PLANIFICACION
        public void escribir_planificacion(String dato, int x, int y, DataGridView tabla)
        {
            tabla[y, x].Value = dato; //de acuerdo a la coordenada del datagridview         
        }

        //VARIABLES QUE SE USAN COMO BANDERAS , QUE NOS INDICAN EN QUE COORDENAS SE VAN
        //A PINTAR, Y "d" EN QUE FILA VAMOS A TOMAR EL COLOR DE LA TABLA PROCESOS
        int xx = 0, yy = 0; //coordenadas que sirviran para pintar
        int d = 0; //coordenas para recorrer fila tabla-procesos
        //para recorrer cada fila y columna se empiezan con los subindices 0
        
        
        //ESTA FUNCION REALIZA LAS OPERACIONES NECESARIAS PARA RESTAR DE LA CANTIDAD NECESARIA DEL CPU
        //EN LA TABLA PROCESOS
        public void procesar()
        {            
            if (fiprocesos()-1 > 0) //entra ala tabla de listado de procesos para verificar si hay datos en procesar para la planificacion
            {         
                int estado = 0;
                while ((d <= fiprocesos() - 1)&&(estado==0))
                {                 
                    int cpu =Convert.ToInt32(tblprocesos[1, d].Value);
                    String nombreProceso=Convert.ToString(tblprocesos[0, d].Value);
                    if (cpu != 0)
                    {
                        estado =1;
                        Console.WriteLine("VALOR CPU"+cpu);
                        String resta = Convert.ToString(cpu - Convert.ToInt32(txtquantum.Text));//asignamos nuevo valor
                        int valresta = Convert.ToInt32(resta);
                        if(valresta>=0) //CUANDO EL VALOR ES MAYOR QUE CERO, esta es importante para q las cantidades de veces se colorean ala hora de planificar
                        {
                        tblprocesos[1, d].Value = resta;
                            String color = tblprocesos[2, d].Value.ToString();//obtiene nombre de color
                            for (int cant = 1; cant <= Convert.ToInt32(txtquantum.Text); cant++)
                            {
                                escribir_planificacion(nombreProceso, xx, yy, tblprocesamiento);
                                s.escribir("Proceso= " + nombreProceso + "Cantidad: "+resta+"Color: " + color+"Quantum: "+txtquantum.Text);
                                pintar(color, xx, yy, tblprocesamiento);                                
                                
                                if (yy == colprocesamiento() - 1)
                                {   
                                    xx++;//sumamos para pintar en la nueva fila
                                    yy = -1;
                                }
                                yy++;
                            }
                        }
                        else if(valresta<0) //EN CASO QUE EL VALOR DEL CPU ES MENOR QUE 0
                        {
                            int pendientevalor = Convert.ToInt32(tblprocesos[1, d].Value);
                            String color = tblprocesos[2, d].Value.ToString();//obtiene nombre de color
                            for (int cant = pendientevalor; cant <=pendientevalor; cant++)
                            {

                                escribir_planificacion(nombreProceso, xx, yy, tblprocesamiento);
                                s.escribir("Proceso= " + nombreProceso + "Cantidad: " + resta + "Color: " + color + "Quantum: " + txtquantum.Text);
                                pintar(color, xx, yy, tblprocesamiento);
                                //   pintar(color, d, 2, tblprocesos);
                                if (yy == colprocesamiento() - 1)
                                {
                                    Console.WriteLine("columna : " + yy);                                    
                                    xx++;
                                    yy = -1;
                                }
                                yy++;
                            }                        
                            tblprocesos[1, d].Value =0;
                        }
                    }//fin if(cpu!=0);                   
                    d++;
                    if (d == fiprocesos() - 1) //QUE RETORNE A LA PRIMERA FILA EN CASO QUE LLEGO A LA ULTIMA
                    {
                        d = 0;
                        estado = 1;                        
                    }
                }
                
            }
        }
        
        //LLAMA AL TIME PARA HACER EL RESPECTIVO CONTEO
        private void btnprocesar_Click(object sender, EventArgs e)
        {           
            time.Enabled = true;
        }
        int valor = 0; //esta variable esta en deshuso
        private void time_Tick(object sender, EventArgs e)
        {
            procesar(); //llamamos al metodo procesar, donde se encuentra todo el algoritmo para la planificacion
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblprocesamiento.Rows.Add(5);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            ayuda ay = new ayuda();
            ay.Show();
        }

        private void lbletiqueta_Click(object sender, EventArgs e)
        {

        }

        
    }
}
