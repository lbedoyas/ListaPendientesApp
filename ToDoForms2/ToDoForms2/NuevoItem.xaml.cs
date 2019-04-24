using System;
using System.Collections.Generic;
using ToDoForms2.Clases;
using Xamarin.Forms;

namespace ToDoForms2
{
    public partial class NuevoItem : ContentPage
    {


        public NuevoItem()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Tarea NuevaTarea = new Tarea()
            {
                Nombre = nombreEntry.Text,
                Fecha = fechaLimiteDatePicker.Date,
                Hora = horaLimiteTimePicker.Time,
                Completada = false
            };

            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.RutaBD))
            {
                conexion.CreateTable<Tarea>();

                var resultado = conexion.Insert(NuevaTarea);

                if (resultado > 0)
                {
                    DisplayAlert("Exito", "El elemento se guardo", "OK");
                }
                else
                {
                    DisplayAlert("Error", "Intenta de nuevo", "OK");
                }
            }
        }
    }
}
