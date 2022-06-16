<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dropdown Size.aspx.cs" Inherits="Pizza_Calculator.Dropdown_Size" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza Calculator</title>
</head>
<body>
    <form id="form1" runat="server">

      <div>
          <asp:dropdownlist runat="server" autopostback="true" OnSelectedIndexChanged ="Dropdownlist0_SelectedIndexChanged" id="Dropdownlist0">
         </asp:dropdownlist>
     </div>

        <div>
           
                        <asp:dropdownlist runat="server" id="Dropdownlist4">

                 <asp:listitem text="Small" value="1"></asp:listitem>
                 <asp:listitem text="Medium" value="2"></asp:listitem>
                 <asp:listitem text="Large" value="3"></asp:listitem>
            </asp:dropdownlist>
        </div>

        <div>
           
                        <asp:dropdownlist runat="server" id="Dropdownlist1">
                 <asp:listitem text="Tomato" value="1"></asp:listitem>
                 <asp:listitem text="BBQ" value="2"></asp:listitem>
                 </asp:dropdownlist>
        </div>

        <div>
           
                        <asp:dropdownlist runat="server" id="Dropdownlist2">
                 <asp:listitem text="Salami" value="1"></asp:listitem>
                 <asp:listitem text="Bacon" value="2"></asp:listitem>
                 <asp:listitem text="Cheese" value="3"></asp:listitem>
            </asp:dropdownlist>
        </div>

    </form>
</body>
</html>
