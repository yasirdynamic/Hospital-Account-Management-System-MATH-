<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DirectorHome.aspx.cs" Inherits="FinalMath.DirectorHome" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <title>MATH</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" href="images/softicon.jpg">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="Content/Admin/plugins/fontawesome-free/css/all.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <!-- DataTables -->
    <link rel="stylesheet" href="Content/Admin/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css">
    <link rel="stylesheet" href="Content/Admin/plugins/datatables-responsive/css/responsive.bootstrap4.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="Content/Admin/dist/css/adminlte.min.css">
    <!-- Google Font: Source Sans Pro -->

    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body class="hold-transition sidebar-mini">

    <form id="form1" runat="server">
        <div class="wrapper">
            <!-- Navbar -->
            <nav class="main-header navbar navbar-expand navbar-white navbar-light">
                <!-- Left navbar links -->
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" data-widget="pushmenu" href="#" role="button"><i class="fas fa-bars"></i></a>
                    </li>
                    <li class="nav-item d-none d-sm-inline-block">
                        <a href="DirectorHome.aspx" class="nav-link">Home</a>
                    </li>
                    <li class="nav-item d-none d-sm-inline-block">
                        <a href="DirectorReport.aspx" class="nav-link">Report</a>
                    </li>

                </ul>
                <!-- Right navbar links -->
                <ul class="navbar-nav ml-auto">
                    <%--  <li class="nav-item dropdown">
                        <a class="nav-link" data-toggle="dropdown" href="#">
                            <i class="far fa-bell"></i>
                            <span class="badge badge-warning navbar-badge">15</span>
                        </a>
                        <div class="dropdown-menu dropdown-menu-lg dropdown-menu-right">
                            <span class="dropdown-item dropdown-header">15 Notifications</span>
                            <div class="dropdown-divider"></div>
                            <a href="#" class="dropdown-item">
                                <i class="fas fa-envelope mr-2"></i>4 new messages
                                <span class="float-right text-muted text-sm">3 mins</span>
                            </a>
                            <div class="dropdown-divider"></div>
                            <a href="#" class="dropdown-item">
                                <i class="fas fa-users mr-2"></i>8 friend requests
                                <span class="float-right text-muted text-sm">12 hours</span>
                            </a>
                            <div class="dropdown-divider"></div>
                            <a href="#" class="dropdown-item">
                                <i class="fas fa-file mr-2"></i>3 new reports
                                <span class="float-right text-muted text-sm">2 days</span>
                            </a>
                            <div class="dropdown-divider"></div>
                            <a href="#" class="dropdown-item dropdown-footer">See All Notifications</a>
                        </div>
                    </li>--%>
                    <li class="nav-item">
                        <a class="nav-link" href="login.aspx" role="button">
                            <i class=" fa fa-lock"></i>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" data-widget="control-sidebar" data-slide="true" href="#" role="button">
                            <i class="fas fa-th-large"></i>
                        </a>
                    </li>
                </ul>
            </nav>
            <!-- /.navbar -->
            <!-- Main Sidebar Container -->
            <aside class="main-sidebar sidebar-dark-primary elevation-4">
                <!-- Brand Logo -->
                <a href="#" class="brand-link">
                    <img src="Content/Admin/dist/img/AdminLTELogo.png"
                        alt="AdminLTE Logo"
                        class="brand-image img-circle elevation-3"
                        style="opacity: .8">
                    <span class="brand-text font-weight-light">MATH</span>
                </a>

                <!-- Sidebar -->
                <div class="sidebar">
                    <!-- Sidebar Menu -->
                    <nav class="mt-2">
                        <ul class="nav nav-pills nav-sidebar flex-column" data-widget="treeview" role="menu" data-accordion="false">
                            <!-- Add icons to the links using the .nav-icon class
    with font-awesome or any other icon font library -->
                            <li class="nav-item">
                                <a href="DirectorHome.aspx" class="nav-link">
                                    <i class="nav-icon fas fa-home"></i>
                                    <p>
                                        Home

                                    </p>
                                </a>
                            </li>
                            <li class="nav-item">
                                <asp:LinkButton ID="linkmanageusers" OnClick="linkmanageusers_Click" runat="server" class="nav-link">
                                
                                    <i class="nav-icon fas fa-th"></i>
                                    <p>
                                        Manage Users

                                    </p>
                                
                                </asp:LinkButton>
                            </li>
                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="lnkmanageemployee" OnClick="lnkmanageemployee_Click" runat="server" class="nav-link">
                                
                                <i class="nav-icon fas fa-copy"></i>
                                    <p>
                                        Manage Employees

                                    </p>
                                </asp:LinkButton>

                            </li>

                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="linkpatient" OnClick="linkpatient_Click" runat="server" class="nav-link">
                                
                                    <i class="nav-icon fas fa-tree"></i>
                                    <p>
                                        Manage Patient

                                    </p>
                                </asp:LinkButton>
                            </li>
                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="lnldishead" OnClick="lnldishead_Click" runat="server" class="nav-link">
                                    <i class="nav-icon fas fa-ad"></i>
                                    <p>
                                        DisHead

                                    </p>
                                </asp:LinkButton>

                            </li>
                            <li class="nav-item has-treeview">
                                 <asp:LinkButton ID="lnkdistype" OnClick="lnkdistype_Click" runat="server" class="nav-link">
                                    <i class="nav-icon fas fa-ad"></i>
                                    <p>
                                        DisType

                                    </p>
                                </asp:LinkButton>

                            </li>
                            <li class="nav-item has-treeview">
                               <asp:LinkButton ID="lnkdue" OnClick="lnkdue_Click" runat="server" class="nav-link">
                                    <i class="nav-icon fas fa-inbox"></i>
                                    <p>
                                        DUE

                                    </p>
                                 </asp:LinkButton>

                            </li>

                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="lnkfinancialyear" OnClick="lnkfinancialyear_Click" runat="server" class="nav-link">
                                      <i class="nav-icon fas fa-yen-sign"></i>
                                    <p>
                                        Financial Year

                                    </p>
                                </asp:LinkButton>
                            </li>
                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="lnkbtnmanageheads" OnClick="lnkbtnmanageheads_Click" runat="server" class="nav-link">
                             
                                    <i class="nav-icon fas fa-head-side-mask"></i>
                                    <p>
                                        Manage Heads

                                    </p>
                                </asp:LinkButton>
                            </li>
                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="lnkbtnmanageheadtype" OnClick="lnkbtnmanageheadtype_Click" runat="server" class="nav-link">
                             
                                    <i class="nav-icon fas fa-anchor"></i>
                                    <p>
                                        Manage Heads Types

                                    </p>
                                </asp:LinkButton>
                            </li>
                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="lnkbtnmodeofpayment" OnClick="lnkbtnmodeofpayment_Click" runat="server" class="nav-link">                             
                                    <i class="nav-icon fas fa-plus-square"></i>
                                    <p>
                                        MODES_OF_PAYMENTS

                                    </p>
                                </asp:LinkButton>
                            </li>
                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="lnkbtnvendors" OnClick="lnkbtnvendors_Click" runat="server" class="nav-link">                             
                                     <i class="nav-icon fas fa-people-arrows"></i>
                                    <p>
                                        VENDORS

                                    </p>
                                </asp:LinkButton>
                            </li>
                            <li class="nav-item has-treeview">
                                <asp:LinkButton ID="lnksal" OnClick="lnksal_Click" runat="server" class="nav-link">                             
                                     <i class="nav-icon fas fa-dollar-sign"></i>
                                    <p>
                                        Salary_Sheet

                                    </p>
                                </asp:LinkButton>
                            </li>
                           
                        </ul>
                    </nav>
                    <!-- /.sidebar-menu -->
                </div>
                <!-- /.sidebar -->
            </aside>
            <div class="content-wrapper">

                <div>


                    <!-- Content Header (Page header) -->
                    <div class="content-header">
                        <div class="container-fluid">
                            <div class="row mb-2">
                                <div class="col-sm-6">
                                    <h1 class="m-0 text-dark">Dashboard</h1>
                                </div>
                                <div class="col-sm-6">
                                    <ol class="breadcrumb float-sm-right">
                                        <li class="breadcrumb-item"><a href="#">Home</a></li>
                                        <li class="breadcrumb-item active">Dashboard</li>
                                    </ol>
                                </div>
                            </div>
                        </div>
                    </div>

                    <section class="content">
                        <div class="container-fluid">
                            <!-- Small boxes (Stat box) -->
                            <div class="row">
                                <div class="col-lg-3 col-6">
                                    <!-- small box -->
                                    <div class="small-box bg-info">
                                        <div class="inner">
                                            <h3>Rs. 
                                <asp:Label ID="lblincome" runat="server" Text="0"></asp:Label></h3>

                                            <p>Total Income</p>
                                        </div>
                                        <div class="icon">
                                            <i class="ion ion-bag"></i>
                                        </div>
                                        <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>
                                <!-- ./col -->
                                <div class="col-lg-3 col-6">
                                    <!-- small box -->
                                    <div class="small-box bg-success">
                                        <div class="inner">
                                            <h3>Rs. 
                                <asp:Label ID="lblexp" runat="server" Text="0"></asp:Label></h3>

                                            <p>Total Expense</p>
                                        </div>
                                        <div class="icon">
                                            <i class="ion ion-stats-bars"></i>
                                        </div>
                                        <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-6">
                                    <!-- small box -->
                                    <div class="small-box bg-danger">
                                        <div class="inner">
                                            <h3>Rs. 
                                <asp:Label ID="lblprofitloss" runat="server" Text="0"></asp:Label></h3>

                                            <p>Surplus/Deficit</p>
                                        </div>
                                        <div class="icon">
                                            <i class="ion ion-pie-graph"></i>
                                        </div>
                                        <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>
                                <!-- ./col -->
                                <div class="col-lg-3 col-6">
                                    <!-- small box -->
                                    <div class="small-box bg-warning">
                                        <div class="inner">
                                            <h3>Rs. 
                                <asp:Label ID="lbldonation" runat="server" Text="0"></asp:Label></h3>

                                            <p>Current Donation</p>
                                        </div>
                                        <div class="icon">
                                            <i class="ion ion-person-add"></i>
                                        </div>
                                        <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>

                            </div>


                            <div class="row">
                                <div class="col-lg-3 col-6">

                                    <div class="small-box bg-info">
                                        <div class="inner">
                                            <h3>
                                                <asp:Label ID="lblemp" runat="server" Text="0"></asp:Label></h3>

                                            <p>Working Emplyee</p>
                                        </div>
                                        <div class="icon">
                                            <i class="ion ion-bag"></i>
                                        </div>
                                        <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>

                                <div class="col-lg-3 col-6">
                                    <!-- small box -->
                                    <div class="small-box bg-success">
                                        <div class="inner">
                                            <h3>
                                                <asp:Label ID="lblpat" runat="server" Text="0"></asp:Label></h3>

                                            <p>Current Patients</p>
                                        </div>
                                        <div class="icon">
                                            <i class="ion ion-stats-bars"></i>
                                        </div>
                                        <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-6">
                                    <!-- small box -->
                                    <div class="small-box bg-danger">
                                        <div class="inner">
                                            <h3>
                                                <asp:Label ID="lblVend" runat="server" Text="0"></asp:Label></h3>

                                            <p>Total Vendors</p>
                                        </div>
                                        <div class="icon">
                                            <i class="ion ion-pie-graph"></i>
                                        </div>
                                        <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>
                                <!-- ./col -->
                                <div class="col-lg-3 col-6">
                                    <!-- small box -->
                                    <div class="small-box bg-warning">
                                        <div class="inner">
                                            <h3>
                                                <asp:Label ID="lbluser" runat="server" Text="0"></asp:Label></h3>

                                            <p>Current Users</p>
                                        </div>
                                        <div class="icon">
                                            <i class="ion ion-person-add"></i>
                                        </div>
                                        <a href="#" class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>
                                <!-- ./col -->


                            </div>


                        </div>
                    </section>

                </div>

            </div>
             <footer class="main-footer">
            <div class="float-right d-none d-sm-block text-sm">
                <b>Designed & Developed By:<a href="https://theultimatedeveloper.com">THE ULTIMATE DEVELOPERS</a></b>
                
            </div>
            <strong class="text-sm">Copyright &copy; 2020 <a href="https://math.org.pk">Mian Afzal Trust Hospital</a></strong> All Rights
            Reserved
        </footer>

            <!-- Control Sidebar -->
            <aside class="control-sidebar control-sidebar-dark">
                <!-- Control sidebar content goes here -->
            </aside>
            <!-- /.control-sidebar -->
        </div>
    </form>
    <!-- ./wrapper -->
    <!-- jQuery -->
    <script src="Content/Admin/plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap 4 -->
    <script src="Content/Admin/plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- DataTables -->
    <script src="Content/Admin/plugins/datatables/jquery.dataTables.min.js"></script>
    <script src="Content/Admin/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js"></script>
    <script src="Content/Admin/plugins/datatables-responsive/js/dataTables.responsive.min.js"></script>
    <script src="Content/Admin/plugins/datatables-responsive/js/responsive.bootstrap4.min.js"></script>
    <!-- AdminLTE App -->
    <script src="Content/Admin/dist/js/adminlte.min.js"></script>
    <!-- AdminLTE for demo purposes -->
    <script src="Content/Admin/dist/js/demo.js"></script>
    <!-- page script -->
    <script>
        $(function () {
            $("#example1").DataTable({
                "responsive": true,
                "autoWidth": false,
            });
            $('#example2').DataTable({
                "paging": true,
                "lengthChange": false,
                "searching": false,
                "ordering": true,
                "info": true,
                "autoWidth": false,
                "responsive": true,
            });
        });</script>
</body>
</html>
