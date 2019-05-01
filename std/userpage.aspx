<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userpage.aspx.cs" Inherits="std.userpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <meta charset="utf-8" />
    <title>UserPage</title>
    <link href="userstylesheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="header">
                <div class=" container">
                    <div id=" NavArea">
                        <div id="dp">

                            <asp:Image ID="imgavatar" ImageUrl="~/Pictures/avatar.png" CssClass="rounded-circle image" runat="server" />
                        </div>
                        <asp:Label ID="lblowner" runat="server" ForeColor=" white" Text="pkay14"></asp:Label>
                        <div id="btnupload">
                            <asp:FileUpload ID="FileUpload1" runat="server" Visible="False" />
                            <asp:Button ID="btnuploadimg" CssClass="btn btn-sm btn-primary" runat="server" Text="Update Image" OnClick="btnuploadimg_Click" />
                        </div>

                        <div id="searchbar">
                            <asp:TextBox ID="txtsearchbox" placeholder="Search User" runat="server" AutoPostBack="True" OnTextChanged="txtsearchbox_TextChanged"></asp:TextBox>
                        </div>
                        <div id="list">
                            <ul id="Nav">

                                <a href="#">
                                    <li>Home</li>
                                </a>
                                <a href="#">
                                    <li>About</li>
                                </a>
                                <a href="#">
                                    <li>Groups</li>
                                </a>
                                <a href="#">
                                    <li>Friends</li>
                                </a>
                                <a href="#">
                                    <li>Contact</li>
                                </a>
                            </ul>
                        </div>

                    </div>
                    <%-- <div id=" NavArea">
                <ul id="Nav">
                    <a href="#"><li>Home</li></a>
                    <a href="#"><li>About</li></a>
                    <a href="#"><li>Groups</li></a>
                    <a href="#"><li>Friends</li></a>
                    <a href="#"><li>Contact</li></a>
                </ul>
            </div>--%>
                </div>
            </div>

            <div id="mainArea" style="margin: 150px">
                <div class="containe page">
                    <h3>This is my demo website made just in 40 minutes </h3>
                    <p>
                        This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                        <br />
                        This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                    </p>
                    <h3><b>Frux Salomon</b> This is my demo website made just in 40 minutes This is my demo website made just in 40 minutesThis is my demo website made just in 40 minutes  </h3>
                    <p>
                        This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                        <br />
                        This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                    </p>
                    <h3>This is my demo website made just in 40 minutes </h3>
                    <p>
                        This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                        <br />
                        This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                    </p>
                    <h3><b>Frux Salomon</b> This is my demo website made just in 40 minutes This is my demo website made just in 40 minutesThis is my demo website made just in 40 minutes  </h3>

                    <p>
                        This is my dem

                <h3>This is my demo website made just in 40 minutes </h3>
                        <p>
                            This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                            <br />
                            This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                        </p>
                        <h3><b>Frux Salomon</b> This is my demo website made just in 40 minutes This is my demo website made just in 40 minutesThis is my demo website made just in 40 minutes  </h3>
                        <p>
                            This is my dem
                <h3>This is my demo website made just in 40 minutes </h3>
                            <p>
                                This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                                <br />
                                This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes This is my demo website made just in 40 minutes
                            </p>
                            <h3><b>Frux Salomon</b> This is my demo website made just in 40 minutes This is my demo website made just in 40 minutesThis is my demo website made just in 40 minutes  </h3>
                            <p>
                    This is my dem
                </div>
            </div>


            <div id="Footer">
                <div class="container">Copy right: Student app, 2019. All right reserved</div>

            </div>
        </div>
    </form>
</body>
</html>
