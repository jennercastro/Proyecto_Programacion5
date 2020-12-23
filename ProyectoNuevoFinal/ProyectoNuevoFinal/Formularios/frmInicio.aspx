<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="frmInicio.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.frmInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css "  type="text/css" />
         <style>
             .carousel-inner .item img {
            width: auto;
            margin: auto;
            height: auto;
            max-height: 300px;
}
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="jumbotron text-center" id="divEncabezadôPagina">
        <h1>Bienvenido a nuestra pagna Inicial</h1>
   
    </div>

                <div id="mycarousel" class="carousel slide" data-ride="carousel">
                    <ol id="olcarousel" class="carousel-indicators">
                    <li data-target="#mycarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#mycarousel" data-slide-to="1"></li>
                    <li data-target="#mycarousel" data-slide-to="2"></li>
                    <li data-target="#mycarousel" data-slide-to="3"></li>
                    </ol>
                    <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <img src="image/imagen1.jfif" /></div>
                    <div class="item">
                        <img src="image/imagen2.jfif" /></div>
                    <div class="item">
                        <img src="image/imagen3.jfif" /></div>
                    <div class="item">
                        <img src="image/imagen4.jfif" /></div>

                    <a class="left carousel-control" href="#mycarousel" role="button" data-slide="prev"><span 
		            class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span><span class="sr-only">Anterior
		            </span></a>

                    <a class="right carousel-control" href="#mycarousel" role="button" data-slide="next"><span 
		            class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span><span class="sr-only">Siguiente
		            </span></a>

                    </div>
                </div>
    <div>
        <div >
            <p class="caja">
                La corredora de Seguros El Equipo del Siglo XXI es una empresa costarricense, 
                nacida en 1935 en San Juan de Tibás. Al ser la primera aseguradora costarricense, 
                se caracterizó por ser una empresa para y por los costarricenses, brindando coberturas
                atractivas con precios accesibles para el público en general
            </p>
        </div>
        <div>
            <p class="caja">
                Como empresa vanguardista, la corredora de Seguros El Equipo del Siglo XXI busca migrar su 
                plataforma de software a una herramienta que sea de libre uso y orientada a objetos; 
                por lo anterior lo ha contratado para que realice una herramienta acorde a las necesidades 
                que se presentarán en los siguientes puntos
            </p>
        </div>
    </div>

  
    <%--siempre es buena practica poner todos los script posterior a todas las etiquetas--%> 
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script type="text/javascript"  src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js "></script>
</asp:Content>