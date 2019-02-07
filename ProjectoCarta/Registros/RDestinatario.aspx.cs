using BLL;
using Entities;
using ProjectoCarta.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectoCarta.Registros
{
    public partial class RDestinatario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Utils.ToInt(Request.QueryString["id"]);
                if (id > 0)
                {
                    RepositorioBase<Destinatario> repositorio = new RepositorioBase<Destinatario>();
                    var registro = repositorio.Buscar(id);
                    LlenaCampos(registro);

                }
            }
        }

        private void Limpiar()
        {
            DestinatarioIdTextBox.Text = "0";
            NombreTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
        }

        private Destinatario LlenaClase(Destinatario destinatario)
        {
            int id;
            bool result = int.TryParse(DestinatarioIdTextBox.Text, out id);
            if (result == true)
            {
                destinatario.DestinatarioId = id;
            }
            else
            {
                destinatario.DestinatarioId = 0;
            }
            destinatario.Nombre = NombreTextBox.Text;
            int cant;
            bool resultado = int.TryParse(CantidadTextBox.Text, out cant);
            if (resultado == true)
            {
                destinatario.CantidadCartas = cant;
            }
            else
            {
                destinatario.CantidadCartas = 0;
            }
            DateTime date;
            bool resultados = DateTime.TryParse(FechaTextBox.Text, out date);
            if (resultados == true)
                destinatario.FechaRegistro = date;
            return destinatario;
        }

        private void LlenaCampos(Destinatario destinatario)
        {
            Limpiar();
            DestinatarioIdTextBox.Text = Convert.ToString(destinatario.DestinatarioId);
            NombreTextBox.Text = destinatario.Nombre;
            CantidadTextBox.Text = Convert.ToString(destinatario.CantidadCartas);
            FechaTextBox.Text = Convert.ToString(destinatario.FechaRegistro);
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Destinatario> repositorioBase = new RepositorioBase<Destinatario>();
            Destinatario destinatario = new Destinatario();
            bool paso = false;

            if (IsValid == false)
            {
                Utils.ShowToastr(this.Page, "Revisar todos los campo", "Error", "error");
                return;
            }

            destinatario = LlenaClase(destinatario);
            if (destinatario.DestinatarioId == 0)
                paso = repositorioBase.Guardar(destinatario);
            else
                paso = repositorioBase.Modificar(destinatario);
            if (paso)
            {
                Utils.ShowToastr(this.Page, "Guardado con exito!!", "Guardado", "success");
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DestinatarioIdTextBox.Text);
            RepositorioBase<Destinatario> repositorio = new RepositorioBase<Destinatario>();
            if (repositorio.Eliminar(id))
            {
                Utils.ShowToastr(this.Page, "Eliminado con exito!!", "Eliminado", "info");
            }
            else
                Utils.ShowToastr(this.Page, "Fallo al Eliminar :(", "Error", "error");
            Limpiar();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Destinatario> repositorio = new RepositorioBase<Destinatario>();
            var destinatario = repositorio.Buscar(Utils.ToInt(DestinatarioIdTextBox.Text));

            if (destinatario != null)
            {
                Limpiar();
                LlenaCampos(destinatario);

                Utils.ShowToastr(this, "Busqueda exitosa", "Exito", "success");
            }
            else
                Utils.ShowToastr(this.Page, "El usuario que intenta buscar no existe", "Error", "error");
        }
    }
}