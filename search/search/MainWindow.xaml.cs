using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
namespace search
{
    public partial class MainWindow : Window,
    INotifyPropertyChanged
    {
 private string _searchText;
 public string SearchText
 {
     get { return _searchText; }
     set
     {
   _searchText = value;
   OnPropertyChanged("SearchText");
   OnPropertyChanged("MyFilteredItems");
     } }
 public List<string> MyItems { get; set; }
 public IEnumerable<string> MyFilteredItems
 {
     get
     {
if (SearchText == null) return MyItems;
return MyItems.Where(x => x.ToUpper().StartsWith(SearchText.ToUpper()));
     }
 }
 public MainWindow()
        {
  InitializeComponent();
  MyItems = new List<string>()
 {
"Paddy O' Riordan  Mobile: 07784204598 / BT: 02868632477",
"N.I PW 645944A ",
"Violets Moblie: 07871754695",
"UlsterBus  028686322633",
"WiFi Router: RJRvzNwNJ3",
"Frank O' Riordan, 63 Eldbridge Close, Feltham, Middlesex, London, TWI49NG ",
"Mother date of birth 1st 11th 1951 ",
"Father date of birth 3rd 10th 1943 ",
"Parents Marriage 15th 3rd 1969 ",
"Librariesni.org.uk PIN: 1272 ",
"bandcamp enniskillenmedia@gmail.com  Username : keshkreations  Password  Paddy1970" ,
"https://blockchainglobal.wordpress.com/ paddyoriordan / password: hellodarling  ",
"wordpress.com / email: fermanaghmedia@gmail.com / username:  paddyoriordan  sign in:  fermanaghmedia / password: paddyoriordan ",
"Wordpress.com / enniskillenmedia / keshmedia ",
"instagram enniskillenmedia keshmedia ",
"paddyoriordan@yahoo.co.uk / Password: Kesh1970 / ID: paddyoriordan ",
"Linkedin / fermanaghmedia@gmail.com /hellodarling ",
"Path fermanaghmedia@gmail.com / hellodarling ",
"tumllr.com / fermanaghmedia@gmail.com / paddyoriordan ",
"FACEBOOK, Gmail account / email: fermanaghmedia@gmail.com / password: hellodarling ",
"TWITTER account for 123D Design also email: fermanaghmedia@gmail.com / password: hellodarling / username: PaddyORiordan1 ",
"soundeffects   http://www.soundeffectsforfree.com  paddyoriordanelvis@gmail.com / password: i7DI1F0zqc ",
"Dropbox  enniskillenmedia@yahoo.co.uk / Password: keshmedia ",
"Godtube  fermanaghmedia@gmail.com / password: hellodarling ",
"Blendswap.com hellodarling / Paddy1970 ",
"blender.org cloud enniskillenmedia@gmail.com / hellodarling ",
"gumtree.com enniskillenmedia@gmail.com / keshmedia ",
"MicroSoft Sign in visual studio 2013 / enniskillenmedia@gmail.com / Kreations ",
"visualstudio http://paddyriordan.visualstudio.com / Profile: Paddy Riordan ",
"onedrive  enniskillenmedia@gmail.com  Code1970 ",
"Godtube fermanaghmedia@gmail.com / hellodarling ",
"Blendswap.com  hellodarling / Paddy1970 ",
"blender.org Cloud enniskillenmedia@gmail.com hellodarling ",
"Gumtree.com enniskillenmedia@gmail.com / keshmedia ",
"camera guy / 02866387133 Irvinewillie@gmail.com / or Irvinewillie@hotmail.com ",
"E.C.D.L by a skills card number which is 15802 ",
"Ronnie Corbett, Centre Manager, Cluain Training & Enterprise Centre, Nelson Street, Clonmel, Co Tipperary. Telephone: 052 6125328 Email: infocluain@gmail.com Fax: 052 6127583",
"Hitfilm  enniskillenmedia@gmail.com  Name: Paddy1970  Password: Code1970 ",
"E-bay  enniskillenmedia@gmail.com  Paddy1970Kesh",
"nidirect  www.nidirect.gov.uk/ password: Code1970@ ",
"docter foster 02866322707 ",
"UlsterBus 028686322633 ",
"Reallife bookshop: 02866322400 ",
"bandcamp  enniskillenmedia@gmail.com  Username : keshkreations Password: Paddy1970 ",
"GitHub  enniskillenmedia@gmail.com  password: Code2222paddy",
" ",
" ",
" ",

 };
  DataContext = this;
 }
 public event PropertyChangedEventHandler PropertyChanged;
 void OnPropertyChanged(string name)
 {
PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
 }  }}
