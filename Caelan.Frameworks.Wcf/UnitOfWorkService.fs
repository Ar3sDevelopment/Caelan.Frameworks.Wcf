namespace Caelan.Frameworks.Wcf.Classes

open System
open System.Data.Entity
open System.Linq
open Caelan.Frameworks.BIZ.Interfaces
open Caelan.Frameworks.BIZ.Classes

[<AbstractClass>]
type GenericUnitOfWorkService<'TUnitOfWork when 'TUnitOfWork :> IUnitOfWork and 'TUnitOfWork :> IDisposable and 'TUnitOfWork : (new : unit
                                                                                                                                     -> 'TUnitOfWork)>() = 
    class
        inherit GenericUnitOfWorkCaller<'TUnitOfWork>()
    end

[<AbstractClass>]
type UnitOfWorkService<'TContext when 'TContext :> DbContext>() = 
    class
        inherit UnitOfWorkCaller<'TContext>()
    end
