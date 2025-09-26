namespace WebAppFormMVC.Models
{
    public class ContactViewModel
    {
        public ContactMessages NuevoMensaje { get; set; }

        public List<ContactMessages> listaMensajes { get; set; } = new List<ContactMessages>();
    }
}
