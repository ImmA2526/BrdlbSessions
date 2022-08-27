using Basic__AllSession;
using Basic__AllSession.nestedNamespace;   // Assembly Refrence OR Namespace OR PAckage
using System;

namespace Basic__AllSession
{
    class Program : S4__AccessModifiereAndKeyword
    {
        static void Main(string[] args)
        {
            //Session 1 Introduction and NamesPace
            //S1__NestedNamespace nameSpace = new S1__NestedNamespace();
            //NestedName nest = new NestedName();
            //nameSpace.Multiplication();
            //nameSpace.Addition();
            //nest.Multiplication();
            //Console.ReadLine();

            //Session 2 Varibale and Data Types
            //S2__VaribaleAndDatatypes varibaleDatatype = new S2__VaribaleAndDatatypes();
            //varibaleDatatype.VariablesAndUses();

            //Session 3 Operator and Conversion
            //S3__OperatorAndTypeConversion operators = new S3__OperatorAndTypeConversion();
            //operators.OperatorAndConversion();

            //Session 4 Access Modifieres And Keywords
            //S4__AccessModifiereAndKeyword modifier = new S4__AccessModifiereAndKeyword();
            //modifier.PublicArithmaticOperation();
            //modifier.PrivateAssignmentOperator();    //need to PrivateMethod explain

            //Program prg = new Program();
            //Child Class
            //ChildClass child = new ChildClass();
            //child.PublicLogicalOperation();
            //prg.ProtectedOperation();

            //Session5 Statement and Selection Stament
            //S5__StatmntAndSelectionStmntProgram stmnt = new S5__StatmntAndSelectionStmntProgram();
            //stmnt.MarkChecker();
            //stmnt.NestedIf();
            //stmnt.SwitchCase();
            //stmnt.SwitchGroup();
            //stmnt.MultipleProgram();

            //Session1 6 Exception Handling
            //S6__StatmntAndExecptionHandlingProgram exception = new S6__StatmntAndExecptionHandlingProgram();
            //exception.LoopThroughName();
            //exception.WhileLoopTable();
            //exception.DoWhileLoopTable();
            //exception.ContinueBreakGoTo();
            //exception.TryCatchBlockWithMultipleCatch();
            //exception.UserException();
            //exception.PerfectNumber();

            //Session 7 Array and Types
            S7__ArraysAndTypes array = new S7__ArraysAndTypes();
            //array.SingleDimensionalArray();
            array.MultiDimensionalArray();

            //Session1 8 Call by Value And Call By Refrence
            //S8__CallBy_ValuesAndRefrenceProgram callBy = new S8__CallBy_ValuesAndRefrenceProgram();
            //callBy.PassByValue();
            //callBy.PassByRefrence();
            //callBy.PassByOut();

            //Session 9 Var and Dynamic
            //S9__VarAndDynamicAndProperties varDynamic = new S9__VarAndDynamicAndProperties();
            //varDynamic.VarAndDynamic();
            //varDynamic.PropertiesMethod();
            //varDynamic.StaticProperty();

            //S10__Params
            S10__ParamsAndIndexer param = new S10__ParamsAndIndexer();
            param.Params_Operation(20, 22, 33, 44);
            param.Params_Array("Sumit", "Sujit", "Abhilasha", "Imran", "Amit", "Anmol");
            param.Params_MultipleValue(2, 3, 4,'A','B',"Amit", "Somesh","Sohel");
            IndexerAccept.Indexer_Accept();
            Console.ReadLine();
        }
    }
}
