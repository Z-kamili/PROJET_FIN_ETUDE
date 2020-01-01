create database Quiz;
use Quiz;
create table Etudiant(
id_etd int primary key identity,
nomcomplet varchar(30),
email varchar(30),
Mtp varchar(12),
date_naissence date,
);
select * from Etudiant
insert into Etudiant values('zakaria kamili','zakariakamili97@gmail.com',1234,'6/3/1997');
create table examen(
id_examen int primary key,
nom_examen varchar(12),
);
alter table examen alter column nom_examen text;
create table Evaluer(
id_etd int references Etudiant(id_etd) ,
id_examen int references examen(id_examen) ,
primary key(id_etd,id_examen),
Note float,
);
 select * from Question
 create table Question(
 id_qte int primary key,
 descriptions text,
 id_examen int references examen(id_examen) on delete cascade on update cascade,
 );
 create table Choix(
 id_choix int primary key,
 descriptions text,
 etats bit,
 id_qte int references Question(id_qte) on delete cascade on update cascade,
 );
 select * from  Choix
 /*insertion*/
 Insert into examen values(1,'Developpement d application Desktop');

 Insert into Question values(1,'Qu est-ce que le C# ?',1),(2,'Qu�est-ce que Visual Studio ?',1),(3,'Quelle est la syntaxe correcte pour d�clarer le nom Nicolas dans une variable ?',1),(4,'Quel est le r�sultat des instructions ci-dessous ?
string chaine="c:\repertoire\";
chaine+="fichier.txt";
Console.WriteLine(chaine);',1);

Insert into Choix values(1,'Un compilateur qui transforme du code interm�diaire en binaire',0,1),(2,'Un langage de programmation permettant de r�aliser des applications informatiques',1,1),(3,'Un framework permettant de r�aliser des applications de toutes sortes',0,1);
Insert into Choix values(5,'Un compilateur qui transforme du code interm�diaire en binaire',0,2),(6,'Un framework permettant de r�aliser des applications de toutes sortes',0,2),(7,'Un environnement de d�veloppement permettant de d�velopper en C#',1,2);
Insert into Choix values(8,'string nom = Nicolas;',0,3),(9,'int nom="Nicolas";',0,3),(10,'string nom="Nicolas";',1,3);
Insert into Choix values(11,'c:\repertoire\',0,4),(12,'c:\repertoire\fichier.txt',0,4),(13,'Ce code ne compile pas',1,4);

<--Mobile-->
  Insert into examen values(2,'Developpement d application Mobile');
Insert into Question values(5,'Qu est-ce que le Java ?',2),(6,'Qu�est-ce que Android Studio ?',2),(7,'Quelle est la syntaxe correcte pour d�clarer le nom Nicolas dans une variable dans Kotlin ?',2),(8,'Quel est la deference entre java et kotlin',2);


Insert into Choix values(14,'Un compilateur qui transforme du code interm�diaire en binaire',0,5),(15,'Un langage de programmation permettant de r�aliser des applications informatiques',1,5),(16,'Un framework permettant de r�aliser des applications de toutes sortes',0,5);
Insert into Choix values(17,'Un compilateur qui transforme du code interm�diaire en binaire',0,6),(18,'Un framework permettant de r�aliser des applications de toutes sortes',0,6),(19,'Un environnement de d�veloppement permettant de d�velopper en Java et kotline',1,6);
Insert into Choix values(20,'string nom = Nicolas;',0,7),(21,'int nom="Nicolas";',0,7),(22,'Var nom="Nicolas";',1,7);
Insert into Choix values(23,'Kotlin plus rapide et simple que java',1,8),(24,'kotlin un langage de declaration ',0,8),(25,'il nya pas la deference',0,8);

<-- WEB-->
Insert into examen values(3,'Developpement d application Web');
Insert into Question values(9,'Qu est-ce que le ASP ?',3),(10,'Quelle est la diff�rence entre ASP.NET MVC et ASP.NET WebForms ?    

',3),(11,'Que veut dire MVC ?

?',3),(12,'Que sont CSS et JavaScript ?',3);

Insert into Question values(13,'Quelle est la r�ponse exacte concernant le code suivant ?

int[] tab = new int[4];',1),(14,'� quoi sert le mot-cl� using ?',1),(15,'Qu affiche le code suivant ?

int i;
for (i = 0; i < 10; i++);
Console.WriteLine(i);',1),(16,'� quoi sert le d�bogueur de Visual Studio ?',1);
-----------------------------------------------------------------------------------------web(Developpement)------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Insert into Question values(17,'Est-ce que je peux m�langer du C# et du HTML ?',3),(18,'Que fait la m�thode View() h�rit�e de la classe de base Controller ?',3),(19,'Dans le pattern MVC, � quoi sert le contr�leur ?',3),(20,'Dans le pattern MVC, qu''est-ce que le mod�le ?',3);

Insert into Choix values(50,'Non, c''est impossible, il faut utiliser le contr�leur',0,17),(51,'Oui, avec le caract�re sp�cial @',1,17),(52,'Oui, gr�ce � l''objet ViewData',0,17);

Insert into Choix values(53,'Elle affiche la vue poss�dant le m�me nom que l''action invoqu�e du contr�leur',1,18),(54,'Elle affiche la vue Index',0,18),(55,'Elle affiche la vue Error',0,18);

Insert into Choix values(56,'� v�rifier que l''on a bien pay� la licence de Visual Studio',0,19),(57,'� g�rer les interactions avec l''utilisateur et � faire le lien entre la vue et le mod�le',1,19),(58,'� �tre certain que les donn�es saisies dans un formulaire sont bien valides',0,19)

Insert into Choix values(59,'un site web que l''on utilise comme mod�le pour ne pas avoir � recr�er un site depuis z�ro',0,20),(60,'un ensemble de classes fournissant l''acc�s aux donn�es de notre application',1,20),(61,'un mapping objet-relationnel (ORM), comme Entity Framework',0,20);
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Insert into Choix values(38,'Le code ne compile pas',0,13),(39,'Le code s ex�cute sans probl�mes',0,13),(40,'Le code provoque une erreur a l�ex�cution car on acc�de � un indice en dehors des limites du tableau',1,13);

Insert into Choix values(41,'� importer un espace de noms',1,14),(42,'� r�f�rencer une assembly du framework .NET',0,14),(43,'� mettre une assembly dans le Global Assembly Cache (GAC)',0,14);

Insert into Choix values(44,'0123456789',0,15),(45,'9',0,15),(46,'10',1,15);

Insert into Choix values(47,'� inspecter le contenu des variables pendant l�ex�cution',0,16),(48,'� parcourir le code pas � pas
',0,16),(49,'Aux 3 fonctions ci-dessus
',1,16);
--------------------------------------------------------------Mobile---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Insert into Question values(21,'Quelle nouveaut� de Java 7 vous permet de simplifier votre red�finition des m�thodes equals() et hashCode() ?',2),(22,'Qu�est-ce qu�un package ?',2),(23,'Dans le langage Java, qu�est-ce qu�une interface ?',2),(24,'Qu''est-ce qu''un JRE ?

',2);
delete from choix  where id_choix = 62;
Insert into Choix values(62,'La classe java.util.Object',0,21),(63,'La classe java.util.Comparable',0,21),(64,'La classe java.util.Equals et java.util.Hashcode',1,21);
Insert into Choix values(65,'C�est un endroit o� ranger nos classes.',1,22),(66,'C�est une classe du langage Java.',0,22),(67,'C�est une classe du langage Java permettant de cr�er plusieurs objets � l�int�rieur.',0,22);
Insert into Choix values(68,'Une fen�tre permettant � l�utilisateur d�interagir avec le programme.
',0,23),(69,'Une classe abstraite',1,23),(70,'Une classe pr�sente dans un package du langage Java servant de base � tous les objets du langage.',0,23);

Insert into Choix values(71,'Un environnement permettant d�ex�cuter des programmes �crits en Java.',1,24),(72,'Une instruction du langage Java.',0,24),(73,'Un site web r�f�ren�ant les fonctionnalit�s d�un langage de programmation.',0,24);
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------







Insert into Choix values(26,'Un compilateur qui transforme du code interm�diaire en binaire',0,9),(27,'Un langage de programmation permettant de r�aliser des applications informatiques',0,9),(28,'Un framework permettant de r�aliser des applications de toutes sortes',1,9);
Insert into Choix values(29,'Aucune diff�rence, c est la m�me chose',0,10),(30,'Ce sont deux logiques diff�rentes de d�veloppement, bas�es sur le m�me socle ASP.NET',1,10),(31,'ASP.NET WebForms permet de r�aliser des applications clientes lourdes alors qu ASP.NET MVC permet de r�aliser des applications web',0,10);
Insert into Choix values(32,'Mieux Vaut Coder',0,11),(33,'Model View Controller',1,11),(34,'Mod�liser Visuellement son Code',0,11);
Insert into Choix values(35,'des compagnons du langage HTML qui permettent de modifier la pr�sentation d un site web et d y ajouter de l interactivit�',1,12),(36,'des outils d ASP.NET qui peuvent �tre utilis�s avec le langage C#',0,12),(37,'des balises HTML qui permettent de mettre en forme du texte',0,12);
select * from Choix;