******************** Statrtup.CS ****************
its executed first when application starts.
the root folder of project its like global asax in dotnet its configured using usestartup<T> at the time of configuring host in main().
it can be configured using usestartup<T>() at the time of configuring host in main.
it contains 2 methods : Configure Services 2) Configure
1)Configure Services() :-- in that you can registr dependent class. with built in IOC.
after registration it can be used anywhere. you just need to include it in the parameter 
of the constructor.
it used ISErviceCollection parameter to register services 

2) Configure() :-- you can configure application request piepline. it uses IApplication builder
that is provide by built in IOC Container.
IAPPlication Builder , IHostingEnviroment , ILoggerFactory these services are framework services
injected by built in IOC Container.

******************** Add Transient **************
every time a new instance is created. Transient creates new instance for every service/ controller as well as for every request and every user.
it dispose End of Request

******************** Add Singleton **************
When we register a type as singleton, only one instance is available throughout the application and for every request.
It is similar to having a static object.
The instance is created for the first request and the same is available throughout the application and for each subsequent requests.
it despose when app is shotdown.

********************* Add Scoped **************** 
When we register a type as Scoped, one instance is available throughout the application per request. When a new request comes in, the new instance is created. 
Add scoped specifies that a single object is available per request.
it dispose End of Request 

******************* Swagger Gen *****************
provides the functionality to generate JSON Swagger documents that describe the objects, methods, return types, etc.

********************* APP Setting Json **********
it contain application setting. in this we can define our database connectivity also it contain jwt Key and logging detail of our 
application.

********************* LAunchSetting.JSON ********
it describes how a project can be launched. It describes the command to run, whether the browser should be opened, 
which environment variables should be set, and so on. This information can then be used by dotnet to run or debug our application.

****************** ISERVICE COLLECTION **********
its an empty interfaceit inherits ILIST<serviceDescriptor>.
it create serviceDescriptor and adds it to the list  Service Collection Calss  implement ISErviceCollection Interface.

********************* ISERVICE PROVIDER *********
it include get service method the service provider class implements iserviceprovider interface. it return registered service with the Container.

************** ORM :--Object Relation Mapping ***
Object Relation Mapping (ORM) is used for data processing from a relational database to modeling 
(logical objects or domain classes) In this, data-management tasks act on object-oriented objects that are almost non-scalar values.
it use to transfer Linq statement into SQL statement.

*************** wwwROOT FOLDER ******************
treated as web root folder static file can be served from the root folder of an application or any other folder of an application.
it send data to server in background.

********************* IIS SERVER **************** 
Internet Information Services is an extensible web server software created by Microsoft for use with the Windows NT family. 
IIS supports HTTP, HTTP/2, HTTPS, FTP, FTPS, SMTP and NNTP.
An IIS web server accepts requests from remote client computers and returns the appropriate response. This basic 
functionality allows web servers to share and deliver information across local area networks (LAN), such as corporate intranets, 
and wide area networks (WAN), such as the internet.

************* Code First Approach ***************
in this we will create entity classes with define properties.entity framework create database and 
tabel based on the entity classes. so database is genrated from code when the code will run.
good for small application and database version contol.

****************** Database First ***************
in this database and tables created first then you create entity model using the created model.
its simple to create model , gui based , mapping and key creation is easy.

***************** IEnumrable & Iqueryble ********

IEnumerable and IQueryable are interfaces that allows you to manipulate and query collections of data. 
IEnumerable is inherited by IQueryable, that means IQueryable add features to IEnumerable interfac

IENumrable 							IQueryble

System.Collection.Namespace			System.Linq.Namespace
Linq to Object & Linq to xml		Linq to SQL
No lazy loading 					Lazy loading
In memory Query 					Out Memory Query
Dont support custom query 			Suport custom query


********************** Inheritance **************
it allows you to define child class that reuses or modifies the behaviour of parent class the class whose members are inherited 
calls base class . the class that inherits memebre of the base class called derived class.

**************** Abstract Class & Interface *****
Abstract Class 								 		Interface

Abstract Class allow you to create functionality	its contain functionality not implement it and whereas												
that subclass can implement or override.	
--it contain defination and Declaration     	  	--it contains only a declaration parties
--its not achive by abstract class.					--multiple inheritance is achived.
--it contain constructor.							--it dosnt contain constructor.
--it contain static memeber.						--it dosnt contain static memeber.
--the performance is fast.							--performance is slow.
--it contain one class.								--it contain multiple class.

****************** AJAX *************************
Asynchronous javascript and xml. it uses combination of built in xml request and html dom to display.
its not transport data as plain text or json.it allow web page to be updated synchonously.
flow of ajax 

Browser(event occur,create http request and send) >> internet>>> Server(process request,create response and send back ) >>>internet >>>>> 
Browser(process return data using javascript)

******************** JWT is JSON Web Token ******
It’s a token that only the server can generate, and can contain a payload of data.
it use HMAC algorithm it contain Header, Payload, Signature. so its secured.
A JWT payload can contain things like UserID or Email so that when the client sends you 
a JWT, you can be sure that it is issued by you.It is an open standard which allows transmitting 
data between parties as a JSON object in a secure and compact way. The data transmitting using JWT 
between parties are digitally signed so that it can be easily verified and trusted.

********************* Controller ****************
A controller is responsible for controlling the way that a user interacts with an MVC application. A controller 
contains the flow control logic. A controller determines what response to send back to 
a user when a user makes a browser request. Controller class contains public methods called Action methods. Controller and its 
action method handles incoming browser requests, retrieves necessary model data and returns appropriate responses.

******************** REPOSITORY *****************
The repository pattern is intended to create an abstraction layer between the data access layer and the business 
logic layer of an application. It is a data access pattern that prompts a more 
loosely coupled approach to data access. We create the data access logic in a 
separate class, or set of classes, called a repository with the responsibility of
 persisting the application's business model.MVC controllers interact with repositories to load and persist an application 
business model. By taking advantage of dependency injection (DI), repositories 
can be injected into a controller's constructor.

********************* DB Context **************** 
A DbContext instance represents a combination of the Unit Of Work and Repository patterns such that it can be used 
to query from a database and group together changes that will then be written back to the store as a unit. 
DbContext is conceptually similar to ObjectContext.It is a bridge between your domain or entity classes and the database

************* Dependancy Injection ************** 
The Dependency Injection pattern uses a builder object to initialize objects and provide the required dependencies to the object 
means it allows you to "inject" a dependency from outside the class.
When class A uses some functionality of class B, then its said that class A has a dependency of class B.

***************Types of Dependacy Injection
Constructor Injection:-- the dependencies are provided through a class constructor.
Setter Injection:-- the client exposes a setter method that the injector uses to inject the dependency.
Interface Injection:-- the dependency provides an injector method that will inject the dependency into any client passed to it. 
Clients must implement an interface that exposes a setter method that accepts the dependency.

******************* MVC ************************* 
Model :- its troe data retrive from database.
View :- view is an interface it display data to the user 
Controller:- it handle the userr request the user uses view and raised an http request.

********************* Route *********************
Routing enables us to define a URL pattern that maps to the request handler. This request handler can be a file or class.and this will 
store into the routeTable which define the route of your application.

******************* First or Default ************ 
When you always want one record no matter what the result set contains, use First or FirstOrDefault.
First or FirstOrDefault. When you want a default value if the result set contains no record,
use FirstOrDefault.It returns first specific element from a collection of elements if one or
more than one match found for that element. 

************** Single or Defalut ****************
it can handle null value when there is only one record is present in data base.
When you want an exception to be thrown if the result set contains many records, use Single or SingleOrDefault.

******************** Lambda Expression **********
its an anoymous expression. it contain parameter and expression
parameter -> Expression.
expression are limited they have to return value immediatly and they cant contain variable assignment or statement.
A lambda expression is a short block of code which takes in parameters and returns a value. Lambda expressions 
are similar to methods, but they do not need a name and they can be implemented right in the body of a method.

******************** Design Principals **********
Solid Principle.:-
S:-single responibility principle
	only one reason to change.
O:- Opn Close Principlal
	class is opn for extension and closed for modification.
L:liskow Substitution Principle
	u shold be able to use derive clss instead of parent class and it 
	behva in same mannr.withou modification
I:Interface Segration Principle.
	clint shold not be forced to implement interface they dont use.
	small interface are preferd.
D:Dependancy Inversion Principle
it state that high level module clss should not depend on low level module
both sold depend upon abstraction.

************ DEsign PAtterns ********************

A design pattern is a description of a set of interacting classes that provide a 
framework for a solution to a generalized problem in a specific context or environment. 
In other words, a pattern suggests a solution to a particular problem or issue in object-oriented software development.

Creational PAtterns:

Abstract Factory:- create instace of several familiys.
Builder :- seprate object construction from its represtetion.
Factory Method:- create an instace of several derived class
Prototype:-fully initialise instce copied or clone.
Singleton:- class which only a single instace can exist.

Structural PAtterns

Adapter:- match interface of diffrent classes.
Bridge:- seprate object from implementetion.
Composite:- tree structor of simple and compositie object
Decoder:- add responsibility to object dynamically
Facade :- single class reprsent an entire subsytym.

Behavioural PAtterns

Chain of Represetneteion:- passing request between chain of objects.
Command:- encapsulate command object.
Interpreter:- way to include language in program.

******************** MVC ROUTER *****************
ASP.NET MVC routes are responsible for determining which controller method to execute for 
a given URL. A URL consists of the following properties: Route Name: A route is a URL pattern that 
is mapped to a handler. A handler can be a controller in the MVC application that processes the request
it contain route name ,url pattern,deffault value,constraints.

******************** From BOdy ******************
To force Web API to read a simple type from the request body, add the [FromBody] attribute to the parameter:
When a parameter has [FromBody], Web API uses the Content-Type header to select a formatter

************** JSON STINGIFY ********************
The JSON. stringify() method converts a JavaScript object or value to a JSON string, optionally replacing 
values if a replacer function is specified or optionally including only the specified properties if a replacer array is specified.

************************ HMAC *******************
Hash-Based Message Authentication Codes (HMACs) are a group of algorithms that provide a way of signing messages by means of a 
shared key. In the case of HMACs, a cryptographic hash function is used (for instance SHA256).

**************** ROUTING ************************
Routing is one of those methods. It allows the user to switch between pages without refreshing the page. 

********************* JOINS *********************
join is used to combine and retrive value from two or more table 
>>(INNER) JOIN:-- it returns matching values in both tables
>>LEFT (OUTER) JOIN:-- Returns all records from the left table, and the matched records from the right table
>>RIGHT (OUTER) JOIN:-- Returns all records from the right table, and the matched records from the left table
>>FULL (OUTER) JOIN:-- Returns all records when there is a match in either left or right table

************* LINQ QUERY ************************
language integrated query is uniform query to retrive data from difrent sources and formatt
it return result as object it enable object oriented approach. it uses standered query operator 
and alsso it uses IEnumerable and IQueryable. there are 50 standered operator are availible in linq.

************** Stored Procedure *****************
it Encapsulate complex database queiris and command which can be call to execute on database for respective result.
its Reusable code that you can save in a database data dictionary. They help you extract, edit, and remove data from a database without 
writing the code to do so again and again. They save your time, reduce workloads, and increase productivity.
Tpes of Stored Procedure ==> (1) System Defined :-- it start with sp_ . and these procedure are alredy define in SQl server. 
(2) Extended :--  it start with xp_ & its Stored in Master Database 
(3) USer Defined:--Created by User for own action. these can be created in all database except resource database
(4) CLR Stored Procedure:-- Common Language Runtime and its introduced in Sql server 2008.  
(5) Remote Stored Procedure:-- stored in database on remote server.

********************* JSON **********************
javascript object notation its a data interchange format its easy for human to read and write data in form of key and value
and its easy for machine to parse data. its language independant. Data  Supported  >> Colection and Ordered List Values in it.
TYPES :-(1) Sereialise **********
it convert dotnet object into json text. it read and write json data directoly to stream. it save state of object
it through serialisation eexception when the data have multiple memebre with same name.
its used for write class object to file.

(2) DeSereialise ****************
it convert json strin to custom dotnet object it can be loded into memory. it alows you to enable process reconstruct of an 
object whenever required.
it used for recover object from file.
**********Types (1) Binary (2) XML (3) JSON Searialisation Deserialisation.

******************** Redis Cashe ****************
its an open source cahing framework this store cache information.
its a noSQL key-value cache that stores the information in hash table format.it provide to store difrnt type of data like string
list,hasesh sets etc.. it stored cashe data in local memory.

***************** Distributed Cashe  ************
its a cashe shared by multiple app servers typically maintained as an external service to the app server that access. it improve 
performance and scalability of application. its implementetion specific it use IDistributed cashe interface.
IDistributed cashe Provide Methods >>> Get, Getasync ,Set, Setasync(Form of [ array ]) ,Refresh, Refreshasync, Remove , Removeasync

*********************** Task  ********************
it represent operation or process that dosnt return value and its executes asynchronously. task object is one of the bestcentral component 
for task-based asynchronous pattern. it contain Iscanceled, IsCompleted , IsFaulted Status in it. 
and its presented in System.Threading.Task Namespace module.

******************** Await ***********************
it suspend the evaluation of the enclosing async method until the asynchronous operation represented its operand completes. when the asynchronous 
operation complete it await method return the result. and without suspension of program it return the result.

******************** Async ***********************
it runs synchronously until it reches first await experession at which poit the method is suspended until awited task is completed.
if the method dont contain await keyword it run asynchronously.

************ Sliding Expiration Tym **************
this automatically send the refresh authentication cookie once the existing cookie is half-way to expiration if the user is logged in 
during the expiration of cookie.it uses the middle ware ordering to send the refresh cookie.

******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************
******************** Async ***********************