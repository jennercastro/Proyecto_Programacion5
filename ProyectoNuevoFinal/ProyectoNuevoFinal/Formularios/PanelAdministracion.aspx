<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/PaginaMaestra.Master" AutoEventWireup="true" 
    CodeBehind="PanelAdministracion.aspx.cs" Inherits="ProyectoNuevoFinal.Formularios.PanelAdministracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="main container">

				<div class="mainbody container-fluid">
    <div class="row">


        <div style="padding-top: 50px;"></div>
        <div class="col-lg-3 col-md-3 hidden-sm hidden-xs">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="media">

                            <div class="media-body">
                                <div align="center">

                                        <img class="img-thumbnail img-responsive" src="@imageSrc" />

                                </div>
                                <hr>
                                <h4><strong>Administrador.</strong></h4>
                                
                                <hr>
                            </div>
                                        
                    </div>
                </div>
            </div>
        </div>

        <!---Publicadad p/ el usuario-->

        <div class="col-lg-9 col-md-9 col-sm-12 col-xs-12">
            <div class="panel panel-default">
                <div class="panel-body">
                    <div class="pull-left">
                        <a href="#">
                            <div align="center">
                            </div>
                        </a>
                    </div>
                    <span>
                        <strong>
                            <h4 class="panel-title pull-left" style="font-size: 30px;">
                                <a href="#" style="text-decoration: none;">
								<p>Bienvenido 
                                    </p>
                    <p>
                        <asp:Label ID="LblNombreCompleto" runat="server"></asp:Label>
                    </p>
                    <p> 
                                    <asp:Label ID="Label1" runat="server" Text="usted ingresó por última vez "></asp:Label>
                    <span>
                        <strong>
                                <a href="#" style="text-decoration: none;">
                    <asp:Label ID="LblFechaHora" runat="server"></asp:Label>

                
                                </a>
                        </strong>
                    </span>
                    </p>
                                </a><i class="fa fa-check text-success" aria-hidden="true" data-toggle="tooltip" data-placement="bottom" title=""></i>
                                                                                          
                            </h4>
                        </strong>
                    </span>
                    <span class="pull-right">
                        <!---mi cerrar session-->
                    </span>
                    <br>
                    <br>
                    <br>
                    <br>
                    <hr>
                    <span class="pull-left">
                        <script type="text/javascript">
                            //Funcion del reloj
                             function startTime() {
                                 today = new Date();
                                 h = today.getHours();
                                 m = today.getMinutes();
                                 s = today.getSeconds();
                                 m = checkTime(m);
                                 s = checkTime(s);
                                 document.getElementById('reloj').innerHTML ="La hora actual es: "+ h + ":" + m + ":" + s+".";
                                 t = setTimeout('startTime()', 500);
                                 //document.write(h + ":" + m + ":" + s);
                             }
                             function checkTime(i)
                             { if (i < 10) { i = "0" + i; } return i; }
                             window.onload = function () { startTime(); }

                            //Funcion de la fecha
                             var d = new Date();
                             var dia = new Array(7);
                             dia[0] = "Domingo";
                             dia[1] = "Lunes";
                             dia[2] = "Martes";
                             dia[3] = "Miercoles";
                             dia[4] = "Jueves";
                             dia[5] = "Viernes";
                             dia[6] = "Sabado";

                             function makeArray() {
                                 for (i = 0; i < makeArray.arguments.length; i++)
                                     this[i + 1] = makeArray.arguments[i];
                             }
                             var months = new makeArray('Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo',
                                 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre');
                             var date = new Date();
                             var day = date.getDate();
                             var month = date.getMonth() + 1;
                             var yy = date.getYear();
                             var year = (yy < 1000) ? yy + 1900 : yy;
                             document.write("La fecha de hoy es " + dia[d.getDay()] + " " + day + " de " + months[month] + " del " + year+".");
                        </script>
                        <div>
                            <div id="reloj" style="font-size: 15px;"></div>

                        </div>
                    </span>
                    <span class="pull-right">

                        <form action="" method="post" class="navbar-form navbar-right">
                            <button class="btn btn-success" onclick=""><span class="glyphicon glyphicon-chevron-left"></span> Volver.</button>
                            <button class="btn btn-info" onclick="">Editar <span class="glyphicon glyphicon-user"></span></button>
                        


                    </span>
                    <br/><br/>

                
                    <br/>
                    <!-- Simple post content example. -->
                    <div class="panel panel-default">
                        <div class="panel-body">
                            <section id="blog">
                                <div class="container">
                                    <div class="row">
									
                                        <div class="col-lg-11 col-md-11">
                                            <div class="row">
                                                <div class="col-sm-4">
                                                    <div class="panel panel-blue">
                                                        <div class="panel-heading">
                                                        </div>
                                                        <div id="dd" class="panel-body">
                                                            <a href="#" onclick="" class="thumb pull-center">
                                                                <img class="img-thumbnail img-responsive" src="" />Usuarios
                                                            </a>
                                                        </div>

                                                        <br />
                                                        <center><asp:Button ID="btnUsuarios" class="btn btn-primary" role="button" runat="server" Text="Administrar Usuarios" OnClick="btnUsuarios_Click" ></asp:Button></center>
                                                        
                                                    </div>
                                                </div>
                                                <div class="col-sm-4">
                                                    <div class="panel panel-success">
                                                        <div class="panel-heading">
                                                        </div>
                                                        <div id="color" class="panel-body">
                                                            <a href="#" class="thumb pull-center">
                                                                <img onclick="" class="img-thumbnail img-responsive" src="" />
                                                            </a>
                                                        </div>
                                                        <br />
                                                        <center><asp:Button ID="btnCoverturas" class="btn btn-success" role="button" runat="server" Text="Administrar Coberturas" OnClick="btnCoverturas_Click"></asp:Button></center>
                                                    </div>

                                                </div>
                                                <div class="col-sm-4">
                                                 <div class="panel panel-blue">
                                                        <div class="panel-heading">
                                                        </div>
                                                        <div id="if" class="panel-body">
                                                            <a href="#" class="thumb pull-center">
                                                                <img onclick="" class="img-thumbnail img-responsive" src="" />
                                                            </a>
                                                        </div>
                                                        <br />
                                                        <center><asp:Button ID="btnReportePoliza"  class="btn btn-warning" role="button" runat="server" Text="Reporte de Polizas" OnClick="btnReportePolizas_Click"></asp:Button> </center>
                                                    </div>
                                                    </div>
                                                <div class="col-sm-4">
                                                    <div class="panel panel-yellow">
                                                        <div class="panel-heading">
                                                        </div>
                                                        <div id="ii" class="panel-body">
                                                            <a href="#" class="thumb pull-center">
                                                                <img onclick="" class="img-thumbnail img-responsive" src="" />
                                                            </a>
                                                        </div>
                                                        <br />
                                                        <center><asp:Button ID="btnAdicciones" class="btn btn-warning" role="button" runat="server" Text="Administrar Adicciones" OnClick="btnAdicciones_Click"></asp:Button> </center>
                                                    </div>
                                                </div>
                                                  <div class="col-sm-4">                                                
                                                    <div class="panel panel-blue">
                                                        <div class="panel-heading">
                                                        </div>
                                                        <div id="if" class="panel-body">
                                                            <a href="#" class="thumb pull-center">
                                                                <img onclick="" class="img-thumbnail img-responsive" src="" />
                                                            </a>
                                                        </div>
                                                        <br />
                                                        <center><asp:Button ID="btnReporteAdicciones" class="btn btn-warning" role="button" runat="server" Text="Reporte de Adiciones" OnClick="btnReporteAdicciones_Click"></asp:Button> </center>
                                                        </div> 
                                                    </div>
                                                 <div class="col-sm-4"> 
                                                    <div class="panel panel-blue">
                                                        <div class="panel-heading">
                                                        </div>
                                                        <div id="if" class="panel-body">
                                                            <a href="#" class="thumb pull-center">
                                                                <img onclick="" class="img-thumbnail img-responsive" src="" />
                                                            </a>
                                                        </div>
                                                        <br />
                                                        <center><asp:Button ID="btnRegistroUsuario" class="btn btn-warning" role="button" runat="server" Text="Registro de Usuarios" OnClick="btnRegistroUsuario_Click"></asp:Button> </center>
                                                    </div>
                                                     </div>
                                                     </div>
                                           
                                        
                                                        <div class="panel-heading">
                                                        </div>
                                                        <div id="ii0" class="panel-body">
                                                            <a href="#" class="thumb pull-center">
                                                                <img onclick="" class="img-thumbnail img-responsive" src="" />
                                                            </a>
                                                        </div>
                                                        <br />
                                                        <center> </center>
                                        </form>





                                    </div>
                                </div>
                            </section>
                            <hr>
                        </div>
                    </div>
                </div>
            </div>

            <hr>

        </div>
    </div>
</div>



				<center>
				
					<div class="center-block">
						
						<ul class="pagination">
							<li class="disabled"><a href="#">&laquo; <span class="sr-only">Anterior</span></a></li>
							<li class="active"><a href="#">1</a></li>
							<li><a href="#">1</a></li>
							<li><a href="#">2</a></li>
							
							<li><a href="#">&raquo;<span class="sr-only">Siguiente</span> </a></li>
						</ul>
					
					</div>				
			
				</center>
        </div>
</asp:Content>