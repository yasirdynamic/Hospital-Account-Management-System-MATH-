<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FinalMath.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <title>MATH</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="icon" href="images/softicon.jpg"/>
    <!-- Font Awesome -->
    <link rel="stylesheet" href="~/Content/Admin/plugins/fontawesome-free/css/all.min.css"/>
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"/>
    <!-- icheck bootstrap -->
    <link rel="stylesheet" href="~/Content/Admin/plugins/icheck-bootstrap/icheck-bootstrap.min.css"/>
    <!-- Theme style -->
    <link rel="stylesheet" href="~/Content/Admin/dist/css/adminlte.min.css"/>
    <!-- Google Font: Source Sans Pro -->
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet"/>
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <a href="mahpk.org"><b>Mian Afzal Trust Hospital</b></a>
        </div>

        <form id="form1" runat="server">
            <div>
                <div class="card">
                    <div class="card-body login-card-body">
                        <p class="login-box-msg">Sign in to start your session</p>


                        <asp:Label ID="lblmsg" Visible="false" class=" form-control alert alert-danger" role="alert" runat="server"></asp:Label>

                        <div class="input-group mb-3">
                            <asp:DropDownList ID="ddlaccounttype" class="form-control" runat="server">
                            </asp:DropDownList>

                            <div class="input-group-append">
                                <div class="input-group-text">
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <asp:TextBox ID="txtusername" required class="form-control" placeholder="User Name" runat="server"></asp:TextBox>

                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <span class="fas fa fa-user"></span>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <asp:TextBox ID="txtpassword" required TextMode="Password" class="form-control" placeholder="Password" runat="server"></asp:TextBox>
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <span class="fas fa fa-sign"></span>
                                </div>
                            </div>
                        </div>
                         
                        <div class="row">
                            <div class="col-8" style="margin-left:55px;margin-right:50px" > 
                               
                                <asp:Button ID="btnSignin" runat="server" OnClick="btnSignin_Click" class="btn btn-primary btn-block" Text="Sign In"/>
                            </div>
                            <br />
                            <br />
                            <div align="center">
                                <b style="font-size: small">Designed & Developed By:<a href="https://theultimatedeveloper.com"> The Ultimate Developers</a></b>
                                <b style="font-size: small">Copyright &copy; 2020 <a href="https://math.org.pk">Mian Afzal Trust Hospital</a><br />
                                    All Rights Reserved
                                </b>
                            </div>
                        </div>
                    </div>
                </div>
                </div>
        </form>



    </div>

    <!-- jQuery -->
    <script src="~/Content/Admin/plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap 4 -->
    <script src="~/Content/Admin/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- AdminLTE App -->
    <script src="~/Content/Admin/dist/js/adminlte.min.js"></script>

</body>
</html>

