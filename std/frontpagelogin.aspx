<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frontpagelogin.aspx.cs" Inherits="std.frontpagelogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="bootstrap/Style.css" rel="stylesheet" />
    <link href="bootstrap/glyphicon.css" type="text/css" rel="stylesheet" />




</head>
<body style="background-image: url('Pictures/paris1.jpg')">
    <form id="form1" runat="server">
        <div class="panel-img">
            <img src="Pictures/Panel.png" />
        </div>
        <div>
            <div style="position: absolute; z-index: 1;" id="layer1">
                <div class="modal-body" style="margin: 30px 0px 0px 400px;">
                    <div class="container ">
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="form-group">
                                    <label for="Username" class=" control-label"><span style="color: white">Username</span></label>
                                    <asp:TextBox ID="txtloginusername" Width="200" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtloginusername" ForeColor="Red" ErrorMessage="This field cannot be empty"></asp:RequiredFieldValidator>
                                    <%--<input type="text" class="form-control" id="User Name" title="Enter your Email" placeholder="John@gmail.com" />--%>
                                    <%--<span class="help-block"></span>--%>
                                </div>
                                <%--<div class=" form-group">
                            <label for="Password" class ="control-label"> <span style ="color: white"> Password </span></label>
                            <input type ="text" class =" form-control" id="Password"  name="Password" data-toggle ="Password" title="Type your password"/>
                            <span class ="help-block"></span>
                        </div>--%>
                                <div>
                                    <label for="Password" class="control-label"><span style="color: white">Password </span></label>
                                    <asp:TextBox ID="txtloginpassword" Width="200" TextMode="Password" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtloginpassword" ForeColor="Red" ErrorMessage="This field cannot be empty"></asp:RequiredFieldValidator>
                                    <div>
                                        <%-- <input class="form-control" id="txtpassword" type="password" />--%>

                                        <div class="input-group-addon">
                                            <a href="#"><i class="" aria-hidden="false"></i></a>
                                        </div>
                                    </div>
                                </div>

                                <div class="Col-lg-6" style="padding: 50px 0px 0px 0px">
                                    <asp:Button runat="server" width="235" ID="btnlogin" Text="Login" CssClass="btn  btn-success" OnClick="btnlogin_Click"></asp:Button>
                                </div>
                                 
                            </div>
                            
                            <div class="col-lg-2">
                                <div>
                                    <asp:Label ID="lblmessage" runat="server" ></asp:Label>
                                </div>


                            </div>
                        </div>
                    </div>



                    
                     <div class=" container col-lg-12"">
                         <div class="row">

                       
                         <div class="col-lg-6"  style="padding: 100px 0px 100px 0px">
                              <button type="submit" class="btn btn-warning btn-sm ">Forgot Login</button>
                         </div>
                      
                     

                 <div  class="col-lg-6" style="padding: 100px 0px 0px 50px">
                               <button class="btn btn-primary btn-sm" type="button">
                <span class=" glyphicon glyphicon-user"></span>Register now for free
             <a href="Login.aspx">
            </button>
                 </div>
               
                    </div>
                     </div>
                </div>
                
                     


            </div>
            
        </div>
        <div style="float: right; padding-right: 100px">
            

            
        </div>
    </form>
    <script src="Js/Jquery-3.1.1.min.Js"></script>
    <script src="Js/bootstrap.min.js"></script>
</body>
</html>

