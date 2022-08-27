using OOPS__AllSession;
using System;
using System.Threading;
using static OOPS__AllSession.S11__ClassAndTypes;


namespace Oops__AllSession
{
    class OopsSessions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welcome To Main Method***********");

            //S11__ClassAndTypes classType = new S11__ClassAndTypes();

            //StudentDetail abstractClass = new StudentDetail();
            //abstractClass.AbstractClassAndDisplayDetail();

            //PartialDetail partialClass = new PartialDetail();
            //partialClass.PartialClass();
            //StaticClass.Static_Method();
            //BaseClass.Sealed_Data();

            //S12__FourPilllars(Abstraction, Encapsulation, Polymorphism, Inheritance)
            //S12__FourPillars__AbsEncapPolyMorpInhrtnc fourPillars = new S12__FourPillars__AbsEncapPolyMorpInhrtnc();
            //fourPillars.NonAbstraction_Method();

            //Encapsulation polymorPhism = new Encapsulation();
            //polymorPhism.PolyMorphism();

            //Single_Inheritance childClass = new Single_Inheritance();
            //childClass.Single_InheritanceMethod();

            //Multiple_Inheritance multiple_Inheritance = new Multiple_Inheritance();
            //multiple_Inheritance.Parent_InheritanceMethod();

            //multiple_Inheritance.Multilevel_InheritanceMethod();
            //multiple_Inheritance.Hirarchical_InheritanceMethod();

            //multiple_Inheritance.Multiple_InheritanceAccess();
            //multiple_Inheritance.Parent_InheritanceMethod();

            //S13__MethodAnd Types
            //S13__MethodsAndTypes_MthdOverlod_Override methods = new S13__MethodsAndTypes_MthdOverlod_Override();
            //methods.StringManupulation();
            //methods.Substraction(60, 30);

            //MethodOverLoading methodOverload_Override = new MethodOverRiding();
            //methodOverload_Override.Addition_MethodOverride();

            //S14__Extension Method And Interface

            //S14__ExtensionMethodAndInterface extensionMethod = new S14__ExtensionMethodAndInterface();
            //extensionMethod.StudentDetails();
            //extensionMethod.PrintMonth();
            //int[] number = { };
            //number.PrintArrayNumber();
            //extensionMethod.MultiDimensionalArray();

            //S15__ConstructorAndTypes
            //S15__ConstructorAndTypes defaultConstructor = new S15__ConstructorAndTypes();
            //S15__ConstructorAndTypes parameteriseConstructor = new S15__ConstructorAndTypes(101, "Abhishek", 33, "Pune");
            //parameteriseConstructor.ParameterizedConstructor();
            //S15__ConstructorAndTypes copyConstructor = new S15__ConstructorAndTypes(parameteriseConstructor);
            //copyConstructor.ParameterizedConstructor();

            //PrivateConstructor privateConstructor = new PrivateConstructor();//Not Able to Create Object
            //PrivateConstructor.GetData();
            //Console.ReadLine();

            //S16__DelegatesAndEvents
            //S16__DelegatesAndEvents delegates = new S16__DelegatesAndEvents();
            //Single
            //PrintNumbers positiveNumber = new PrintNumbers(S16__DelegatesAndEvents.PrintPositiveNumbers);  //Single
            //positiveNumber.Invoke();

            //***************EVENTS******************
            //EventNotifications eventNotify = new EventNotifications();
            //eventNotify.notificationEvent += User1.User1_Message;
            //eventNotify.notificationEvent += User2.User2_Message;

            //eventNotify.NotificationMethod();

            //Multiple 1
            //string[] city = { "Panvel", "Pune", "Nanded", "Latur", "Beed", "Mumbai", "Dubai" };
            //PrintNames printCity = new PrintNames(delegates.PrintCityName);
            //printCity.Invoke(city);

            //Adding Refrence to Method or Pointing to method
            //string[] names = { "Amit", "Amir", "Sahiba", "Imran", "Kanak", "Prakash",", "Akhil", "Shubham" };
            //printCity = S16__DelegatesAndEvents.PrintPersonName;
            //printCity.Invoke(names);

            //Multicast
            //string[] fullName = { "ImranShaikh" };
            //printCity += S16__DelegatesAndEvents.PrintName;
            //printCity.Invoke(fullName);

            //S17__Anonymous Function 
            //S17__AnonymousMethodAndLambdaExpression anonymousMethod = new S17__AnonymousMethodAndLambdaExpression();
            //S17__AnonymousMethodAndLambdaExpression.AnonymousMethod();

            //S18__StringAndStrinBuilder stringBuilder = new S18__StringAndStrinBuilder();
            //stringBuilder.StringManupulation();
            //stringBuilder.StringBuilder();
            //stringBuilder.StringBuilder_Methods();

            //S19__GenericAndReflections generic = new S19__GenericAndReflections();
            //generic.CalledGenericMethod();

            //S20__MultiThreading Threading
            //Default Thread___
            //Thread thread = Thread.CurrentThread;
            //thread.Name = "---Main Thread and Single.----";
            //Console.WriteLine("Printing Default Thread----");
            //

            //S20__MultiThreading multithreading = new S20__MultiThreading();
            //Time Sharing   
            //need to remove thread time from the condiion for runnig time sharing 
            //Thread thread1 = new Thread(multithreading.PrintNamesArray);
            //Thread thread2 = new Thread(multithreading.PrintMultiplication);
            //Thread thread3 = new Thread(multithreading.PrintNumberList);

            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            //multithreading.PrintNamesArray();
            //multithreading.PrintMultiplication();
            //multithreading.PrintNumberList();

            //S21__AsyncAwait asyncAwait = new S21__AsyncAwait();

            //Console.WriteLine("Calling ASync Method:  ");
            //var asyncMethod = asyncAwait.AsyncMethod();

            //Console.WriteLine("Calling Sync Method:  ");
            //var syncMethod = asyncAwait.SyncMethod();

            S22__LinQ linq = new S22__LinQ();
            linq.PrintNames();

            ProductReview productLinQ = new ProductReview();
            productLinQ.CallingMethods();
        }
    }
}
