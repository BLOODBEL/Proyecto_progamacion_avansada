﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIProyecto
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProyectoPAEntities1 : DbContext
    {
        public ProyectoPAEntities1()
            : base("name=ProyectoPAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clase> Clase { get; set; }
        public virtual DbSet<ClaseEntrenador> ClaseEntrenador { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Estadisticas> Estadisticas { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<InscritoEn> InscritoEn { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Salario> Salario { get; set; }
        public virtual DbSet<Suscripcion> Suscripcion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    
        public virtual int ActualizarCuenta(string identificacion, string nombre, string apellidos1, string apellidos2, string correoElectronico, string telefono, Nullable<long> idUsuario)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidos1Parameter = apellidos1 != null ?
                new ObjectParameter("Apellidos1", apellidos1) :
                new ObjectParameter("Apellidos1", typeof(string));
    
            var apellidos2Parameter = apellidos2 != null ?
                new ObjectParameter("Apellidos2", apellidos2) :
                new ObjectParameter("Apellidos2", typeof(string));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("CorreoElectronico", correoElectronico) :
                new ObjectParameter("CorreoElectronico", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarCuenta", identificacionParameter, nombreParameter, apellidos1Parameter, apellidos2Parameter, correoElectronicoParameter, telefonoParameter, idUsuarioParameter);
        }
    
        public virtual int ActualizarEstadoUsuario(Nullable<long> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarEstadoUsuario", idUsuarioParameter);
        }
    
        public virtual int ActualizarSalario(Nullable<long> idSalario, Nullable<decimal> nuevoSalario, string nuevaDescripcion)
        {
            var idSalarioParameter = idSalario.HasValue ?
                new ObjectParameter("idSalario", idSalario) :
                new ObjectParameter("idSalario", typeof(long));
    
            var nuevoSalarioParameter = nuevoSalario.HasValue ?
                new ObjectParameter("nuevoSalario", nuevoSalario) :
                new ObjectParameter("nuevoSalario", typeof(decimal));
    
            var nuevaDescripcionParameter = nuevaDescripcion != null ?
                new ObjectParameter("nuevaDescripcion", nuevaDescripcion) :
                new ObjectParameter("nuevaDescripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarSalario", idSalarioParameter, nuevoSalarioParameter, nuevaDescripcionParameter);
        }
    
        public virtual ObjectResult<IniciarSesion_Result> IniciarSesion(string correoElectronico, string contrasenna)
        {
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("CorreoElectronico", correoElectronico) :
                new ObjectParameter("CorreoElectronico", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IniciarSesion_Result>("IniciarSesion", correoElectronicoParameter, contrasennaParameter);
        }
    
        public virtual int RegistrarCuenta(string identificacion, string nombre, string apellidos1, string apellidos2, string correoElectronico, string contrasenna, string telefono)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidos1Parameter = apellidos1 != null ?
                new ObjectParameter("Apellidos1", apellidos1) :
                new ObjectParameter("Apellidos1", typeof(string));
    
            var apellidos2Parameter = apellidos2 != null ?
                new ObjectParameter("Apellidos2", apellidos2) :
                new ObjectParameter("Apellidos2", typeof(string));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("CorreoElectronico", correoElectronico) :
                new ObjectParameter("CorreoElectronico", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarCuenta", identificacionParameter, nombreParameter, apellidos1Parameter, apellidos2Parameter, correoElectronicoParameter, contrasennaParameter, telefonoParameter);
        }
    }
}
