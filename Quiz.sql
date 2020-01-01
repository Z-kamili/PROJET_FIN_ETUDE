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

 Insert into Question values(1,'Qu est-ce que le C# ?',1),(2,'Qu’est-ce que Visual Studio ?',1),(3,'Quelle est la syntaxe correcte pour déclarer le nom Nicolas dans une variable ?',1),(4,'Quel est le résultat des instructions ci-dessous ?
string chaine="c:\repertoire\";
chaine+="fichier.txt";
Console.WriteLine(chaine);',1);

Insert into Choix values(1,'Un compilateur qui transforme du code intermédiaire en binaire',0,1),(2,'Un langage de programmation permettant de réaliser des applications informatiques',1,1),(3,'Un framework permettant de réaliser des applications de toutes sortes',0,1);
Insert into Choix values(5,'Un compilateur qui transforme du code intermédiaire en binaire',0,2),(6,'Un framework permettant de réaliser des applications de toutes sortes',0,2),(7,'Un environnement de développement permettant de développer en C#',1,2);
Insert into Choix values(8,'string nom = Nicolas;',0,3),(9,'int nom="Nicolas";',0,3),(10,'string nom="Nicolas";',1,3);
Insert into Choix values(11,'c:\repertoire\',0,4),(12,'c:\repertoire\fichier.txt',0,4),(13,'Ce code ne compile pas',1,4);

<--Mobile-->
  Insert into examen values(2,'Developpement d application Mobile');
Insert into Question values(5,'Qu est-ce que le Java ?',2),(6,'Qu’est-ce que Android Studio ?',2),(7,'Quelle est la syntaxe correcte pour déclarer le nom Nicolas dans une variable dans Kotlin ?',2),(8,'Quel est la deference entre java et kotlin',2);


Insert into Choix values(14,'Un compilateur qui transforme du code intermédiaire en binaire',0,5),(15,'Un langage de programmation permettant de réaliser des applications informatiques',1,5),(16,'Un framework permettant de réaliser des applications de toutes sortes',0,5);
Insert into Choix values(17,'Un compilateur qui transforme du code intermédiaire en binaire',0,6),(18,'Un framework permettant de réaliser des applications de toutes sortes',0,6),(19,'Un environnement de développement permettant de développer en Java et kotline',1,6);
Insert into Choix values(20,'string nom = Nicolas;',0,7),(21,'int nom="Nicolas";',0,7),(22,'Var nom="Nicolas";',1,7);
Insert into Choix values(23,'Kotlin plus rapide et simple que java',1,8),(24,'kotlin un langage de declaration ',0,8),(25,'il nya pas la deference',0,8);

<-- WEB-->
Insert into examen values(3,'Developpement d application Web');
Insert into Question values(9,'Qu est-ce que le ASP ?',3),(10,'Quelle est la différence entre ASP.NET MVC et ASP.NET WebForms ?    

',3),(11,'Que veut dire MVC ?

?',3),(12,'Que sont CSS et JavaScript ?',3);

Insert into Question values(13,'Quelle est la réponse exacte concernant le code suivant ?

int[] tab = new int[4];',1),(14,'À quoi sert le mot-clé using ?',1),(15,'Qu affiche le code suivant ?

int i;
for (i = 0; i < 10; i++);
Console.WriteLine(i);',1),(16,'À quoi sert le débogueur de Visual Studio ?',1);
-----------------------------------------------------------------------------------------web(Developpement)------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Insert into Question values(17,'Est-ce que je peux mélanger du C# et du HTML ?',3),(18,'Que fait la méthode View() héritée de la classe de base Controller ?',3),(19,'Dans le pattern MVC, à quoi sert le contrôleur ?',3),(20,'Dans le pattern MVC, qu''est-ce que le modèle ?',3);

Insert into Choix values(50,'Non, c''est impossible, il faut utiliser le contrôleur',0,17),(51,'Oui, avec le caractère spécial @',1,17),(52,'Oui, grâce à l''objet ViewData',0,17);

Insert into Choix values(53,'Elle affiche la vue possédant le même nom que l''action invoquée du contrôleur',1,18),(54,'Elle affiche la vue Index',0,18),(55,'Elle affiche la vue Error',0,18);

Insert into Choix values(56,'à vérifier que l''on a bien payé la licence de Visual Studio',0,19),(57,'à gérer les interactions avec l''utilisateur et à faire le lien entre la vue et le modèle',1,19),(58,'à être certain que les données saisies dans un formulaire sont bien valides',0,19)

Insert into Choix values(59,'un site web que l''on utilise comme modèle pour ne pas avoir à recréer un site depuis zéro',0,20),(60,'un ensemble de classes fournissant l''accès aux données de notre application',1,20),(61,'un mapping objet-relationnel (ORM), comme Entity Framework',0,20);
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Insert into Choix values(38,'Le code ne compile pas',0,13),(39,'Le code s exécute sans problèmes',0,13),(40,'Le code provoque une erreur a l’exécution car on accède à un indice en dehors des limites du tableau',1,13);

Insert into Choix values(41,'À importer un espace de noms',1,14),(42,'À référencer une assembly du framework .NET',0,14),(43,'À mettre une assembly dans le Global Assembly Cache (GAC)',0,14);

Insert into Choix values(44,'0123456789',0,15),(45,'9',0,15),(46,'10',1,15);

Insert into Choix values(47,'À inspecter le contenu des variables pendant l’exécution',0,16),(48,'À parcourir le code pas à pas
',0,16),(49,'Aux 3 fonctions ci-dessus
',1,16);
--------------------------------------------------------------Mobile---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Insert into Question values(21,'Quelle nouveauté de Java 7 vous permet de simplifier votre redéfinition des méthodes equals() et hashCode() ?',2),(22,'Qu’est-ce qu’un package ?',2),(23,'Dans le langage Java, qu’est-ce qu’une interface ?',2),(24,'Qu''est-ce qu''un JRE ?

',2);
delete from choix  where id_choix = 62;
Insert into Choix values(62,'La classe java.util.Object',0,21),(63,'La classe java.util.Comparable',0,21),(64,'La classe java.util.Equals et java.util.Hashcode',1,21);
Insert into Choix values(65,'C’est un endroit où ranger nos classes.',1,22),(66,'C’est une classe du langage Java.',0,22),(67,'C’est une classe du langage Java permettant de créer plusieurs objets à l’intérieur.',0,22);
Insert into Choix values(68,'Une fenêtre permettant à l’utilisateur d’interagir avec le programme.
',0,23),(69,'Une classe abstraite',1,23),(70,'Une classe présente dans un package du langage Java servant de base à tous les objets du langage.',0,23);

Insert into Choix values(71,'Un environnement permettant d’exécuter des programmes écrits en Java.',1,24),(72,'Une instruction du langage Java.',0,24),(73,'Un site web référençant les fonctionnalités d’un langage de programmation.',0,24);
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------







Insert into Choix values(26,'Un compilateur qui transforme du code intermédiaire en binaire',0,9),(27,'Un langage de programmation permettant de réaliser des applications informatiques',0,9),(28,'Un framework permettant de réaliser des applications de toutes sortes',1,9);
Insert into Choix values(29,'Aucune différence, c est la même chose',0,10),(30,'Ce sont deux logiques différentes de développement, basées sur le même socle ASP.NET',1,10),(31,'ASP.NET WebForms permet de réaliser des applications clientes lourdes alors qu ASP.NET MVC permet de réaliser des applications web',0,10);
Insert into Choix values(32,'Mieux Vaut Coder',0,11),(33,'Model View Controller',1,11),(34,'Modéliser Visuellement son Code',0,11);
Insert into Choix values(35,'des compagnons du langage HTML qui permettent de modifier la présentation d un site web et d y ajouter de l interactivité',1,12),(36,'des outils d ASP.NET qui peuvent être utilisés avec le langage C#',0,12),(37,'des balises HTML qui permettent de mettre en forme du texte',0,12);
select * from Choix;