<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hangman.aspx.cs" Inherits="Hangman_WebForms.Hangman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <asp:Panel ID="pnlNewGame" runat="server" Visible="false">
     <div class="container">
         <div class="row">
             <asp:Label  ID="lblMessage" runat="server" CssClass="alert alert-info"></asp:Label>
         </div>
        <div class="row">
            <div class="col-sm-4">
                <asp:Button  ID="btnPlayAgain" runat="server" Text="Play Again" CssClass="btn btn-success" OnClick ="btnPlayAgain_Click"/>
            </div>
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <asp:Button ID="btnExit" runat="server" Text="Exit" CssClass="btn btn-default" OnClick ="btnExit_Click"/>
            </div>
        </div>
     </div>
    </asp:Panel>
    <asp:Panel ID="pnlWord" runat="server"></asp:Panel>
    <asp:Image ID="pbGallows" runat="server" />
    <asp:Panel ID="pnlAlphabet" runat="server">
        <asp:ImageButton ID="btnQ" runat="server" AlternateText="Q" ImageUrl="~/Resources/Q.png" OnClick="btnA_Click" />
        <asp:ImageButton ID="btnW" runat="server" AlternateText="W" ImageUrl="~/Resources/W.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnE" runat="server" AlternateText="E" ImageUrl="~/Resources/E.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnR" runat="server" AlternateText="R" ImageUrl="~/Resources/R.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnT" runat="server" AlternateText="T" ImageUrl="~/Resources/T.png" OnClick="btnA_Click" />
        <asp:ImageButton ID="btnY" runat="server" AlternateText="Y" ImageUrl="~/Resources/Y.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnU" runat="server" AlternateText="U" ImageUrl="~/Resources/U.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnI" runat="server" AlternateText="I" ImageUrl="~/Resources/I.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnO" runat="server" AlternateText="O" ImageUrl="~/Resources/O.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnP" runat="server" AlternateText="P" ImageUrl="~/Resources/P.png" OnClick="btnA_Click"/><br />
        <asp:ImageButton ID="btnA" runat="server" AlternateText="A" ImageUrl="~/Resources/A.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnS" runat="server" AlternateText="S" ImageUrl="~/Resources/S.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnD" runat="server" AlternateText="D" ImageUrl="~/Resources/D.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnF" runat="server" AlternateText="F" ImageUrl="~/Resources/F.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnG" runat="server" AlternateText="G" ImageUrl="~/Resources/G.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnH" runat="server" AlternateText="H" ImageUrl="~/Resources/H.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnJ" runat="server" AlternateText="J" ImageUrl="~/Resources/J.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnK" runat="server" AlternateText="K" ImageUrl="~/Resources/K.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnL" runat="server" AlternateText="L" ImageUrl="~/Resources/L.png" OnClick="btnA_Click"/><br />
        <asp:ImageButton ID="btnZ" runat="server" AlternateText="Z" ImageUrl="~/Resources/Z.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnX" runat="server" AlternateText="X" ImageUrl="~/Resources/X.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnC" runat="server" AlternateText="C" ImageUrl="~/Resources/C.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnV" runat="server" AlternateText="V" ImageUrl="~/Resources/V.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnB" runat="server" AlternateText="B" ImageUrl="~/Resources/B.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnN" runat="server" AlternateText="N"  ImageUrl="~/Resources/N.png" OnClick="btnA_Click"/>
        <asp:ImageButton ID="btnM" runat="server" AlternateText="M"  ImageUrl="~/Resources/M.png" OnClick="btnA_Click"/>
    </asp:Panel>
    <asp:Panel ID="pnlGamerStats" runat="server" CssClass="panel panel-default" >
     <div class="container">
         <div class="row">
            <div class="col-sm-4"><asp:Label runat="server" ID="lblGamerNamer" ></asp:Label></div>
            <div class="col-sm-4"><asp:Label runat="server" ID="lblLongestWord" ></asp:Label></div>
            <div class="col-sm-4"><asp:Label runat="server" ID="lblGamesPlayed" ></asp:Label></div>
         </div>
         <div class="row">
             <div class="col-sm-4"><asp:Label runat="server" ID="lblWins" ></asp:Label></div>
             <div class="col-sm-4"><asp:Label runat="server" ID="lblCurrentWinStreak" ></asp:Label></div>
             <div class="col-sm-4"><asp:Label runat="server" ID="lblLongestWinStreak" ></asp:Label></div>
        </div>
     </div>
        
    </asp:Panel>

</asp:Content>
