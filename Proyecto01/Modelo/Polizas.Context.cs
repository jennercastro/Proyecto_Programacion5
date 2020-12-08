﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto01.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ProyectoProgra5Entities : DbContext
    {
        public ProyectoProgra5Entities()
            : base("name=ProyectoProgra5Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Adiccion> Adiccion { get; set; }
        public DbSet<Adiccion_Usuario> Adiccion_Usuario { get; set; }
        public DbSet<Cobertura_Poliza> Cobertura_Poliza { get; set; }
        public DbSet<Registro_Poliza> Registro_Poliza { get; set; }
        public DbSet<Tipo_Poliza> Tipo_Poliza { get; set; }
        public DbSet<Tipo_Usuario> Tipo_Usuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    
        public virtual ObjectResult<listarUsuarios5_Result> listarUsuarios5()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarUsuarios5_Result>("listarUsuarios5");
        }
    
        public virtual ObjectResult<listarUsuariosWhere5_Result> listarUsuariosWhere5(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listarUsuariosWhere5_Result>("listarUsuariosWhere5", iDParameter);
        }
    
        public virtual ObjectResult<RetonarAdiccionID_Result> RetonarAdiccionID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetonarAdiccionID_Result>("RetonarAdiccionID", iDParameter);
        }
    
        public virtual ObjectResult<RetornaAdicciones_Result> RetornaAdicciones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaAdicciones_Result>("RetornaAdicciones");
        }
    
        public virtual ObjectResult<RetornaAdiccionesUsuario_Result> RetornaAdiccionesUsuario(string primerApellido, string nombre)
        {
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("primerApellido", primerApellido) :
                new ObjectParameter("primerApellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaAdiccionesUsuario_Result>("RetornaAdiccionesUsuario", primerApellidoParameter, nombreParameter);
        }
    
        public virtual ObjectResult<string> RetornaCobertuarPoliza(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("RetornaCobertuarPoliza", iDParameter);
        }
    
        public virtual ObjectResult<RetornaCobertura_Poliza_Result> RetornaCobertura_Poliza()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCobertura_Poliza_Result>("RetornaCobertura_Poliza");
        }
    
        public virtual ObjectResult<RetornaCobertura_PolizaWhere_Result> RetornaCobertura_PolizaWhere(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCobertura_PolizaWhere_Result>("RetornaCobertura_PolizaWhere", iDParameter);
        }
    
        public virtual ObjectResult<RetornaCod_Usuario_Result> RetornaCod_Usuario(Nullable<int> cod_Tipo_Usuario)
        {
            var cod_Tipo_UsuarioParameter = cod_Tipo_Usuario.HasValue ?
                new ObjectParameter("Cod_Tipo_Usuario", cod_Tipo_Usuario) :
                new ObjectParameter("Cod_Tipo_Usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCod_Usuario_Result>("RetornaCod_Usuario", cod_Tipo_UsuarioParameter);
        }
    
        public virtual ObjectResult<RetornaPolizaUsuario_Result> RetornaPolizaUsuario(string primerApellido, string nombre)
        {
            var primerApellidoParameter = primerApellido != null ?
                new ObjectParameter("primerApellido", primerApellido) :
                new ObjectParameter("primerApellido", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaPolizaUsuario_Result>("RetornaPolizaUsuario", primerApellidoParameter, nombreParameter);
        }
    
        public virtual ObjectResult<RetornaTipoUsuario2_Result> RetornaTipoUsuario2(string cod_Tipo_Usuario)
        {
            var cod_Tipo_UsuarioParameter = cod_Tipo_Usuario != null ?
                new ObjectParameter("Cod_Tipo_Usuario", cod_Tipo_Usuario) :
                new ObjectParameter("Cod_Tipo_Usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaTipoUsuario2_Result>("RetornaTipoUsuario2", cod_Tipo_UsuarioParameter);
        }
    
        public virtual ObjectResult<RetornaUsuario_Result> RetornaUsuario(string alias_Usuario, string pass_Usuario)
        {
            var alias_UsuarioParameter = alias_Usuario != null ?
                new ObjectParameter("Alias_Usuario", alias_Usuario) :
                new ObjectParameter("Alias_Usuario", typeof(string));
    
            var pass_UsuarioParameter = pass_Usuario != null ?
                new ObjectParameter("Pass_Usuario", pass_Usuario) :
                new ObjectParameter("Pass_Usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaUsuario_Result>("RetornaUsuario", alias_UsuarioParameter, pass_UsuarioParameter);
        }
    
        public virtual int SP_Actualizar_ADICCION(Nullable<int> id, string nombre)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Actualizar_ADICCION", idParameter, nombreParameter);
        }
    
        public virtual int SP_Actualizar_ADICCION_USUARIO(Nullable<int> id, Nullable<int> cOD_ADICCION, Nullable<int> cOD_USUARIO)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var cOD_ADICCIONParameter = cOD_ADICCION.HasValue ?
                new ObjectParameter("COD_ADICCION", cOD_ADICCION) :
                new ObjectParameter("COD_ADICCION", typeof(int));
    
            var cOD_USUARIOParameter = cOD_USUARIO.HasValue ?
                new ObjectParameter("COD_USUARIO", cOD_USUARIO) :
                new ObjectParameter("COD_USUARIO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Actualizar_ADICCION_USUARIO", idParameter, cOD_ADICCIONParameter, cOD_USUARIOParameter);
        }
    
        public virtual int SP_Actualizar_Cobertura_Poliza(Nullable<int> id, string nombre, string descripcion, Nullable<double> porcentaje)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var porcentajeParameter = porcentaje.HasValue ?
                new ObjectParameter("Porcentaje", porcentaje) :
                new ObjectParameter("Porcentaje", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Actualizar_Cobertura_Poliza", idParameter, nombreParameter, descripcionParameter, porcentajeParameter);
        }
    
        public virtual int SP_Actualizar_Tipo_Poliza(Nullable<int> id, string nombre)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Actualizar_Tipo_Poliza", idParameter, nombreParameter);
        }
    
        public virtual int SP_Actualizar_USUARIO(Nullable<int> id, Nullable<int> cedula, string nOMBRE, string aPELLIDO1, string aPELLIDO2, string cORREO, Nullable<int> tELE1, Nullable<int> tELE2, Nullable<System.DateTime> f_NACIMIENTO, string gENERO, Nullable<int> cOD_tIPO_uSUARIO, Nullable<int> cod_Cobertuta_Poliza, string alias_Usuario, string pass_Usuario, string direccion)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDO1Parameter = aPELLIDO1 != null ?
                new ObjectParameter("APELLIDO1", aPELLIDO1) :
                new ObjectParameter("APELLIDO1", typeof(string));
    
            var aPELLIDO2Parameter = aPELLIDO2 != null ?
                new ObjectParameter("APELLIDO2", aPELLIDO2) :
                new ObjectParameter("APELLIDO2", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var tELE1Parameter = tELE1.HasValue ?
                new ObjectParameter("TELE1", tELE1) :
                new ObjectParameter("TELE1", typeof(int));
    
            var tELE2Parameter = tELE2.HasValue ?
                new ObjectParameter("TELE2", tELE2) :
                new ObjectParameter("TELE2", typeof(int));
    
            var f_NACIMIENTOParameter = f_NACIMIENTO.HasValue ?
                new ObjectParameter("F_NACIMIENTO", f_NACIMIENTO) :
                new ObjectParameter("F_NACIMIENTO", typeof(System.DateTime));
    
            var gENEROParameter = gENERO != null ?
                new ObjectParameter("GENERO", gENERO) :
                new ObjectParameter("GENERO", typeof(string));
    
            var cOD_tIPO_uSUARIOParameter = cOD_tIPO_uSUARIO.HasValue ?
                new ObjectParameter("cOD_tIPO_uSUARIO", cOD_tIPO_uSUARIO) :
                new ObjectParameter("cOD_tIPO_uSUARIO", typeof(int));
    
            var cod_Cobertuta_PolizaParameter = cod_Cobertuta_Poliza.HasValue ?
                new ObjectParameter("Cod_Cobertuta_Poliza", cod_Cobertuta_Poliza) :
                new ObjectParameter("Cod_Cobertuta_Poliza", typeof(int));
    
            var alias_UsuarioParameter = alias_Usuario != null ?
                new ObjectParameter("Alias_Usuario", alias_Usuario) :
                new ObjectParameter("Alias_Usuario", typeof(string));
    
            var pass_UsuarioParameter = pass_Usuario != null ?
                new ObjectParameter("Pass_Usuario", pass_Usuario) :
                new ObjectParameter("Pass_Usuario", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Actualizar_USUARIO", idParameter, cedulaParameter, nOMBREParameter, aPELLIDO1Parameter, aPELLIDO2Parameter, cORREOParameter, tELE1Parameter, tELE2Parameter, f_NACIMIENTOParameter, gENEROParameter, cOD_tIPO_uSUARIOParameter, cod_Cobertuta_PolizaParameter, alias_UsuarioParameter, pass_UsuarioParameter, direccionParameter);
        }
    
        public virtual int SP_ELIMINAR_ADICCION(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_ADICCION", iDParameter);
        }
    
        public virtual int SP_ELIMINAR_ADICCION_USUARIO(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_ADICCION_USUARIO", iDParameter);
        }
    
        public virtual int SP_ELIMINAR_Cobertura_Poliza(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_Cobertura_Poliza", iDParameter);
        }
    
        public virtual int SP_ELIMINAR_Tipo_Poliza(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_Tipo_Poliza", iDParameter);
        }
    
        public virtual int SP_ELIMINAR_USUARIO(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_USUARIO", iDParameter);
        }
    
        public virtual int SP_INSERTA_ADICCION(string nOMBRE)
        {
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERTA_ADICCION", nOMBREParameter);
        }
    
        public virtual int SP_INSERTA_ADICCION_USUARIO(Nullable<int> cOD_ADICCION, Nullable<int> cOD_USUARIO)
        {
            var cOD_ADICCIONParameter = cOD_ADICCION.HasValue ?
                new ObjectParameter("COD_ADICCION", cOD_ADICCION) :
                new ObjectParameter("COD_ADICCION", typeof(int));
    
            var cOD_USUARIOParameter = cOD_USUARIO.HasValue ?
                new ObjectParameter("COD_USUARIO", cOD_USUARIO) :
                new ObjectParameter("COD_USUARIO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERTA_ADICCION_USUARIO", cOD_ADICCIONParameter, cOD_USUARIOParameter);
        }
    
        public virtual int SP_INSERTA_Cobertura_Poliza(string nOMBRE, string descripcion, Nullable<double> porcentaje)
        {
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var porcentajeParameter = porcentaje.HasValue ?
                new ObjectParameter("Porcentaje", porcentaje) :
                new ObjectParameter("Porcentaje", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERTA_Cobertura_Poliza", nOMBREParameter, descripcionParameter, porcentajeParameter);
        }
    
        public virtual int SP_INSERTA_Tipo_Poliza(string nOMBRE)
        {
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERTA_Tipo_Poliza", nOMBREParameter);
        }
    
        public virtual int SP_INSERTA_USUARIO(Nullable<int> cedula, string nOMBRE, string aPELLIDO1, string aPELLIDO2, string cORREO, Nullable<int> tELE1, Nullable<int> tELE2, Nullable<System.DateTime> f_NACIMIENTO, string gENERO, Nullable<int> cOD_tIPO_uSUARIO, Nullable<int> cod_Cobertuta_Poliza, string alias_Usuario, string pass_Usuario, string direccion)
        {
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(int));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDO1Parameter = aPELLIDO1 != null ?
                new ObjectParameter("APELLIDO1", aPELLIDO1) :
                new ObjectParameter("APELLIDO1", typeof(string));
    
            var aPELLIDO2Parameter = aPELLIDO2 != null ?
                new ObjectParameter("APELLIDO2", aPELLIDO2) :
                new ObjectParameter("APELLIDO2", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var tELE1Parameter = tELE1.HasValue ?
                new ObjectParameter("TELE1", tELE1) :
                new ObjectParameter("TELE1", typeof(int));
    
            var tELE2Parameter = tELE2.HasValue ?
                new ObjectParameter("TELE2", tELE2) :
                new ObjectParameter("TELE2", typeof(int));
    
            var f_NACIMIENTOParameter = f_NACIMIENTO.HasValue ?
                new ObjectParameter("F_NACIMIENTO", f_NACIMIENTO) :
                new ObjectParameter("F_NACIMIENTO", typeof(System.DateTime));
    
            var gENEROParameter = gENERO != null ?
                new ObjectParameter("GENERO", gENERO) :
                new ObjectParameter("GENERO", typeof(string));
    
            var cOD_tIPO_uSUARIOParameter = cOD_tIPO_uSUARIO.HasValue ?
                new ObjectParameter("cOD_tIPO_uSUARIO", cOD_tIPO_uSUARIO) :
                new ObjectParameter("cOD_tIPO_uSUARIO", typeof(int));
    
            var cod_Cobertuta_PolizaParameter = cod_Cobertuta_Poliza.HasValue ?
                new ObjectParameter("Cod_Cobertuta_Poliza", cod_Cobertuta_Poliza) :
                new ObjectParameter("Cod_Cobertuta_Poliza", typeof(int));
    
            var alias_UsuarioParameter = alias_Usuario != null ?
                new ObjectParameter("Alias_Usuario", alias_Usuario) :
                new ObjectParameter("Alias_Usuario", typeof(string));
    
            var pass_UsuarioParameter = pass_Usuario != null ?
                new ObjectParameter("Pass_Usuario", pass_Usuario) :
                new ObjectParameter("Pass_Usuario", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_INSERTA_USUARIO", cedulaParameter, nOMBREParameter, aPELLIDO1Parameter, aPELLIDO2Parameter, cORREOParameter, tELE1Parameter, tELE2Parameter, f_NACIMIENTOParameter, gENEROParameter, cOD_tIPO_uSUARIOParameter, cod_Cobertuta_PolizaParameter, alias_UsuarioParameter, pass_UsuarioParameter, direccionParameter);
        }
    
        public virtual int SUMA(Nullable<int> adiccion, Nullable<double> montoAsegurado, Nullable<double> primaImpuesto, Nullable<double> impuesto, Nullable<double> porcentajeCobertura, Nullable<int> numeroAdiccion, Nullable<double> montoAdiccion, Nullable<double> primaFinal, Nullable<int> cod_Cobertura_Poliza, Nullable<int> cod_Cliente, Nullable<int> cod_Tipo_Poliza, Nullable<double> monto1, Nullable<double> monto2)
        {
            var adiccionParameter = adiccion.HasValue ?
                new ObjectParameter("Adiccion", adiccion) :
                new ObjectParameter("Adiccion", typeof(int));
    
            var montoAseguradoParameter = montoAsegurado.HasValue ?
                new ObjectParameter("MontoAsegurado", montoAsegurado) :
                new ObjectParameter("MontoAsegurado", typeof(double));
    
            var primaImpuestoParameter = primaImpuesto.HasValue ?
                new ObjectParameter("PrimaImpuesto", primaImpuesto) :
                new ObjectParameter("PrimaImpuesto", typeof(double));
    
            var impuestoParameter = impuesto.HasValue ?
                new ObjectParameter("Impuesto", impuesto) :
                new ObjectParameter("Impuesto", typeof(double));
    
            var porcentajeCoberturaParameter = porcentajeCobertura.HasValue ?
                new ObjectParameter("PorcentajeCobertura", porcentajeCobertura) :
                new ObjectParameter("PorcentajeCobertura", typeof(double));
    
            var numeroAdiccionParameter = numeroAdiccion.HasValue ?
                new ObjectParameter("NumeroAdiccion", numeroAdiccion) :
                new ObjectParameter("NumeroAdiccion", typeof(int));
    
            var montoAdiccionParameter = montoAdiccion.HasValue ?
                new ObjectParameter("MontoAdiccion", montoAdiccion) :
                new ObjectParameter("MontoAdiccion", typeof(double));
    
            var primaFinalParameter = primaFinal.HasValue ?
                new ObjectParameter("PrimaFinal", primaFinal) :
                new ObjectParameter("PrimaFinal", typeof(double));
    
            var cod_Cobertura_PolizaParameter = cod_Cobertura_Poliza.HasValue ?
                new ObjectParameter("Cod_Cobertura_Poliza", cod_Cobertura_Poliza) :
                new ObjectParameter("Cod_Cobertura_Poliza", typeof(int));
    
            var cod_ClienteParameter = cod_Cliente.HasValue ?
                new ObjectParameter("Cod_Cliente", cod_Cliente) :
                new ObjectParameter("Cod_Cliente", typeof(int));
    
            var cod_Tipo_PolizaParameter = cod_Tipo_Poliza.HasValue ?
                new ObjectParameter("Cod_Tipo_Poliza", cod_Tipo_Poliza) :
                new ObjectParameter("Cod_Tipo_Poliza", typeof(int));
    
            var monto1Parameter = monto1.HasValue ?
                new ObjectParameter("Monto1", monto1) :
                new ObjectParameter("Monto1", typeof(double));
    
            var monto2Parameter = monto2.HasValue ?
                new ObjectParameter("Monto2", monto2) :
                new ObjectParameter("Monto2", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUMA", adiccionParameter, montoAseguradoParameter, primaImpuestoParameter, impuestoParameter, porcentajeCoberturaParameter, numeroAdiccionParameter, montoAdiccionParameter, primaFinalParameter, cod_Cobertura_PolizaParameter, cod_ClienteParameter, cod_Tipo_PolizaParameter, monto1Parameter, monto2Parameter);
        }
    }
}
