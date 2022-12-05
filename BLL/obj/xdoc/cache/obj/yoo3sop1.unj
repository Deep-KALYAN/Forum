id: BLL
language: CSharp
name:
  Default: BLL
qualifiedName:
  Default: BLL
type: Assembly
modifiers: {}
items:
- id: BLL
  commentId: N:BLL
  language: CSharp
  name:
    CSharp: BLL
    VB: BLL
  nameWithType:
    CSharp: BLL
    VB: BLL
  qualifiedName:
    CSharp: BLL
    VB: BLL
  type: Namespace
  assemblies:
  - BLL
  modifiers: {}
  items:
  - id: BLL.AccountService
    commentId: T:BLL.AccountService
    language: CSharp
    name:
      CSharp: AccountService
      VB: AccountService
    nameWithType:
      CSharp: AccountService
      VB: AccountService
    qualifiedName:
      CSharp: BLL.AccountService
      VB: BLL.AccountService
    type: Class
    assemblies:
    - BLL
    namespace: BLL
    source:
      remote:
        path: BLL/AccountService.cs
        branch: main
        repo: https://github.com/Deep-KALYAN/Forum.git
      id: AccountService
      path: ../BLL/AccountService.cs
      startLine: 18
    syntax:
      content:
        CSharp: 'class AccountService : IAccountService'
        VB: >-
          Class AccountService

              Implements IAccountService
    inheritance:
    - System.Object
    implements:
    - BLL.IAccountService
    inheritedMembers:
    - System.Object.Equals(System.Object)
    - System.Object.Equals(System.Object,System.Object)
    - System.Object.GetHashCode
    - System.Object.GetType
    - System.Object.MemberwiseClone
    - System.Object.ReferenceEquals(System.Object,System.Object)
    - System.Object.ToString
    modifiers:
      CSharp:
      - class
      VB:
      - Class
    items:
    - id: BLL.AccountService._dbContext
      commentId: F:BLL.AccountService._dbContext
      language: CSharp
      name:
        CSharp: _dbContext
        VB: _dbContext
      nameWithType:
        CSharp: AccountService._dbContext
        VB: AccountService._dbContext
      qualifiedName:
        CSharp: BLL.AccountService._dbContext
        VB: BLL.AccountService._dbContext
      type: Field
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: _dbContext
        path: ../BLL/AccountService.cs
        startLine: 20
      syntax:
        content:
          CSharp: readonly IUnitOfWork _dbContext
          VB: ReadOnly _dbContext As IUnitOfWork
        return:
          type: DAL.UOW.IUnitOfWork
      modifiers:
        CSharp:
        - readonly
        VB:
        - ReadOnly
    - id: BLL.AccountService.#ctor(DAL.UOW.IUnitOfWork)
      commentId: M:BLL.AccountService.#ctor(DAL.UOW.IUnitOfWork)
      language: CSharp
      name:
        CSharp: AccountService(IUnitOfWork)
        VB: AccountService(IUnitOfWork)
      nameWithType:
        CSharp: AccountService.AccountService(IUnitOfWork)
        VB: AccountService.AccountService(IUnitOfWork)
      qualifiedName:
        CSharp: BLL.AccountService.AccountService(DAL.UOW.IUnitOfWork)
        VB: BLL.AccountService.AccountService(DAL.UOW.IUnitOfWork)
      type: Constructor
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: .ctor
        path: ../BLL/AccountService.cs
        startLine: 22
      syntax:
        content:
          CSharp: public AccountService(IUnitOfWork dbContext)
          VB: Public Sub New(dbContext As IUnitOfWork)
        parameters:
        - id: dbContext
          type: DAL.UOW.IUnitOfWork
      overload: BLL.AccountService.#ctor*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BLL.AccountService.GetUsersAsync
      commentId: M:BLL.AccountService.GetUsersAsync
      language: CSharp
      name:
        CSharp: GetUsersAsync()
        VB: GetUsersAsync()
      nameWithType:
        CSharp: AccountService.GetUsersAsync()
        VB: AccountService.GetUsersAsync()
      qualifiedName:
        CSharp: BLL.AccountService.GetUsersAsync()
        VB: BLL.AccountService.GetUsersAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetUsersAsync
        path: ../BLL/AccountService.cs
        startLine: 30
      syntax:
        content:
          CSharp: public async Task<IEnumerable<_User>> GetUsersAsync()
          VB: Public Function GetUsersAsync As Task(Of IEnumerable(Of _User))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites._User}}
      overload: BLL.AccountService.GetUsersAsync*
      implements:
      - BLL.IAccountService.GetUsersAsync
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.AccountService.GetUserByIdAsync(System.Int32)
      commentId: M:BLL.AccountService.GetUserByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetUserByIdAsync(Int32)
        VB: GetUserByIdAsync(Int32)
      nameWithType:
        CSharp: AccountService.GetUserByIdAsync(Int32)
        VB: AccountService.GetUserByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.AccountService.GetUserByIdAsync(System.Int32)
        VB: BLL.AccountService.GetUserByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetUserByIdAsync
        path: ../BLL/AccountService.cs
        startLine: 38
      syntax:
        content:
          CSharp: public async Task<_User> GetUserByIdAsync(int id)
          VB: Public Function GetUserByIdAsync(id As Integer) As Task(Of _User)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{Domain.Entites._User}
      overload: BLL.AccountService.GetUserByIdAsync*
      implements:
      - BLL.IAccountService.GetUserByIdAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.AccountService.GetUserByloginNameAsync(System.String)
      commentId: M:BLL.AccountService.GetUserByloginNameAsync(System.String)
      language: CSharp
      name:
        CSharp: GetUserByloginNameAsync(String)
        VB: GetUserByloginNameAsync(String)
      nameWithType:
        CSharp: AccountService.GetUserByloginNameAsync(String)
        VB: AccountService.GetUserByloginNameAsync(String)
      qualifiedName:
        CSharp: BLL.AccountService.GetUserByloginNameAsync(System.String)
        VB: BLL.AccountService.GetUserByloginNameAsync(System.String)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetUserByloginNameAsync
        path: ../BLL/AccountService.cs
        startLine: 46
      syntax:
        content:
          CSharp: public async Task<_User> GetUserByloginNameAsync(string loginname)
          VB: Public Function GetUserByloginNameAsync(loginname As String) As Task(Of _User)
        parameters:
        - id: loginname
          type: System.String
        return:
          type: System.Threading.Tasks.Task{Domain.Entites._User}
      overload: BLL.AccountService.GetUserByloginNameAsync*
      implements:
      - BLL.IAccountService.GetUserByloginNameAsync(System.String)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.AccountService.CreateUserAsync(Domain.Entites._User)
      commentId: M:BLL.AccountService.CreateUserAsync(Domain.Entites._User)
      language: CSharp
      name:
        CSharp: CreateUserAsync(_User)
        VB: CreateUserAsync(_User)
      nameWithType:
        CSharp: AccountService.CreateUserAsync(_User)
        VB: AccountService.CreateUserAsync(_User)
      qualifiedName:
        CSharp: BLL.AccountService.CreateUserAsync(Domain.Entites._User)
        VB: BLL.AccountService.CreateUserAsync(Domain.Entites._User)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: CreateUserAsync
        path: ../BLL/AccountService.cs
        startLine: 61
      syntax:
        content:
          CSharp: public async Task<_User> CreateUserAsync(_User newUser)
          VB: Public Function CreateUserAsync(newUser As _User) As Task(Of _User)
        parameters:
        - id: newUser
          type: Domain.Entites._User
        return:
          type: System.Threading.Tasks.Task{Domain.Entites._User}
      overload: BLL.AccountService.CreateUserAsync*
      implements:
      - BLL.IAccountService.CreateUserAsync(Domain.Entites._User)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.AccountService.Encrypt(System.String)
      commentId: M:BLL.AccountService.Encrypt(System.String)
      language: CSharp
      name:
        CSharp: Encrypt(String)
        VB: Encrypt(String)
      nameWithType:
        CSharp: AccountService.Encrypt(String)
        VB: AccountService.Encrypt(String)
      qualifiedName:
        CSharp: BLL.AccountService.Encrypt(System.String)
        VB: BLL.AccountService.Encrypt(System.String)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: Encrypt
        path: ../BLL/AccountService.cs
        startLine: 85
      syntax:
        content:
          CSharp: public static string Encrypt(string password)
          VB: Public Shared Function Encrypt(password As String) As String
        parameters:
        - id: password
          type: System.String
        return:
          type: System.String
      overload: BLL.AccountService.Encrypt*
      modifiers:
        CSharp:
        - public
        - static
        VB:
        - Public
        - Shared
    - id: BLL.AccountService.ModifyUserAsync(Domain.Entites._User)
      commentId: M:BLL.AccountService.ModifyUserAsync(Domain.Entites._User)
      language: CSharp
      name:
        CSharp: ModifyUserAsync(_User)
        VB: ModifyUserAsync(_User)
      nameWithType:
        CSharp: AccountService.ModifyUserAsync(_User)
        VB: AccountService.ModifyUserAsync(_User)
      qualifiedName:
        CSharp: BLL.AccountService.ModifyUserAsync(Domain.Entites._User)
        VB: BLL.AccountService.ModifyUserAsync(Domain.Entites._User)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: ModifyUserAsync
        path: ../BLL/AccountService.cs
        startLine: 107
      syntax:
        content:
          CSharp: public async Task<_User> ModifyUserAsync(_User modifyUser)
          VB: Public Function ModifyUserAsync(modifyUser As _User) As Task(Of _User)
        parameters:
        - id: modifyUser
          type: Domain.Entites._User
        return:
          type: System.Threading.Tasks.Task{Domain.Entites._User}
      overload: BLL.AccountService.ModifyUserAsync*
      implements:
      - BLL.IAccountService.ModifyUserAsync(Domain.Entites._User)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.AccountService.DeleteUserAsync(System.Int32)
      commentId: M:BLL.AccountService.DeleteUserAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DeleteUserAsync(Int32)
        VB: DeleteUserAsync(Int32)
      nameWithType:
        CSharp: AccountService.DeleteUserAsync(Int32)
        VB: AccountService.DeleteUserAsync(Int32)
      qualifiedName:
        CSharp: BLL.AccountService.DeleteUserAsync(System.Int32)
        VB: BLL.AccountService.DeleteUserAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DeleteUserAsync
        path: ../BLL/AccountService.cs
        startLine: 136
      syntax:
        content:
          CSharp: public async Task<bool> DeleteUserAsync(int id)
          VB: Public Function DeleteUserAsync(id As Integer) As Task(Of Boolean)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{System.Boolean}
      overload: BLL.AccountService.DeleteUserAsync*
      implements:
      - BLL.IAccountService.DeleteUserAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.AccountService.Encryp(System.String)
      commentId: M:BLL.AccountService.Encryp(System.String)
      language: CSharp
      name:
        CSharp: Encryp(String)
        VB: Encryp(String)
      nameWithType:
        CSharp: AccountService.Encryp(String)
        VB: AccountService.Encryp(String)
      qualifiedName:
        CSharp: BLL.AccountService.Encryp(System.String)
        VB: BLL.AccountService.Encryp(System.String)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: Encryp
        path: ../BLL/AccountService.cs
        startLine: 152
      syntax:
        content:
          CSharp: public static string Encryp(string clearText)
          VB: Public Shared Function Encryp(clearText As String) As String
        parameters:
        - id: clearText
          type: System.String
        return:
          type: System.String
      overload: BLL.AccountService.Encryp*
      modifiers:
        CSharp:
        - public
        - static
        VB:
        - Public
        - Shared
    - id: BLL.AccountService.Decrypt(System.String)
      commentId: M:BLL.AccountService.Decrypt(System.String)
      language: CSharp
      name:
        CSharp: Decrypt(String)
        VB: Decrypt(String)
      nameWithType:
        CSharp: AccountService.Decrypt(String)
        VB: AccountService.Decrypt(String)
      qualifiedName:
        CSharp: BLL.AccountService.Decrypt(System.String)
        VB: BLL.AccountService.Decrypt(System.String)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/AccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: Decrypt
        path: ../BLL/AccountService.cs
        startLine: 175
      syntax:
        content:
          CSharp: public static string Decrypt(string cipherText)
          VB: Public Shared Function Decrypt(cipherText As String) As String
        parameters:
        - id: cipherText
          type: System.String
        return:
          type: System.String
      overload: BLL.AccountService.Decrypt*
      modifiers:
        CSharp:
        - public
        - static
        VB:
        - Public
        - Shared
  - id: BLL.BLLExtensions
    commentId: T:BLL.BLLExtensions
    language: CSharp
    name:
      CSharp: BLLExtensions
      VB: BLLExtensions
    nameWithType:
      CSharp: BLLExtensions
      VB: BLLExtensions
    qualifiedName:
      CSharp: BLL.BLLExtensions
      VB: BLL.BLLExtensions
    type: Class
    assemblies:
    - BLL
    namespace: BLL
    source:
      remote:
        path: BLL/BLLExtensions.cs
        branch: main
        repo: https://github.com/Deep-KALYAN/Forum.git
      id: BLLExtensions
      path: ../BLL/BLLExtensions.cs
      startLine: 6
    syntax:
      content:
        CSharp: public static class BLLExtensions
        VB: Public Module BLLExtensions
    inheritance:
    - System.Object
    inheritedMembers:
    - System.Object.Equals(System.Object)
    - System.Object.Equals(System.Object,System.Object)
    - System.Object.GetHashCode
    - System.Object.GetType
    - System.Object.MemberwiseClone
    - System.Object.ReferenceEquals(System.Object,System.Object)
    - System.Object.ToString
    modifiers:
      CSharp:
      - public
      - static
      - class
      VB:
      - Public
      - Module
    items:
    - isExtensionMethod: true
      id: BLL.BLLExtensions.AddBLLExtension(Microsoft.Extensions.DependencyInjection.IServiceCollection)
      commentId: M:BLL.BLLExtensions.AddBLLExtension(Microsoft.Extensions.DependencyInjection.IServiceCollection)
      language: CSharp
      name:
        CSharp: AddBLLExtension(IServiceCollection)
        VB: AddBLLExtension(IServiceCollection)
      nameWithType:
        CSharp: BLLExtensions.AddBLLExtension(IServiceCollection)
        VB: BLLExtensions.AddBLLExtension(IServiceCollection)
      qualifiedName:
        CSharp: BLL.BLLExtensions.AddBLLExtension(Microsoft.Extensions.DependencyInjection.IServiceCollection)
        VB: BLL.BLLExtensions.AddBLLExtension(Microsoft.Extensions.DependencyInjection.IServiceCollection)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/BLLExtensions.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: AddBLLExtension
        path: ../BLL/BLLExtensions.cs
        startLine: 8
      syntax:
        content:
          CSharp: public static void AddBLLExtension(this IServiceCollection services)
          VB: >-
            <ExtensionAttribute>

            Public Shared Sub AddBLLExtension(services As IServiceCollection)
        parameters:
        - id: services
          type: Microsoft.Extensions.DependencyInjection.IServiceCollection
      overload: BLL.BLLExtensions.AddBLLExtension*
      modifiers:
        CSharp:
        - public
        - static
        VB:
        - Public
        - Shared
  - id: BLL.ForumService
    commentId: T:BLL.ForumService
    language: CSharp
    name:
      CSharp: ForumService
      VB: ForumService
    nameWithType:
      CSharp: ForumService
      VB: ForumService
    qualifiedName:
      CSharp: BLL.ForumService
      VB: BLL.ForumService
    type: Class
    assemblies:
    - BLL
    namespace: BLL
    source:
      remote:
        path: BLL/ForumService.cs
        branch: main
        repo: https://github.com/Deep-KALYAN/Forum.git
      id: ForumService
      path: ../BLL/ForumService.cs
      startLine: 11
    syntax:
      content:
        CSharp: 'class ForumService : IForumService'
        VB: >-
          Class ForumService

              Implements IForumService
    inheritance:
    - System.Object
    implements:
    - BLL.IForumService
    inheritedMembers:
    - System.Object.Equals(System.Object)
    - System.Object.Equals(System.Object,System.Object)
    - System.Object.GetHashCode
    - System.Object.GetType
    - System.Object.MemberwiseClone
    - System.Object.ReferenceEquals(System.Object,System.Object)
    - System.Object.ToString
    modifiers:
      CSharp:
      - class
      VB:
      - Class
    items:
    - id: BLL.ForumService._dbContext
      commentId: F:BLL.ForumService._dbContext
      language: CSharp
      name:
        CSharp: _dbContext
        VB: _dbContext
      nameWithType:
        CSharp: ForumService._dbContext
        VB: ForumService._dbContext
      qualifiedName:
        CSharp: BLL.ForumService._dbContext
        VB: BLL.ForumService._dbContext
      type: Field
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: _dbContext
        path: ../BLL/ForumService.cs
        startLine: 13
      syntax:
        content:
          CSharp: readonly IUnitOfWork _dbContext
          VB: ReadOnly _dbContext As IUnitOfWork
        return:
          type: DAL.UOW.IUnitOfWork
      modifiers:
        CSharp:
        - readonly
        VB:
        - ReadOnly
    - id: BLL.ForumService.#ctor(DAL.UOW.IUnitOfWork)
      commentId: M:BLL.ForumService.#ctor(DAL.UOW.IUnitOfWork)
      language: CSharp
      name:
        CSharp: ForumService(IUnitOfWork)
        VB: ForumService(IUnitOfWork)
      nameWithType:
        CSharp: ForumService.ForumService(IUnitOfWork)
        VB: ForumService.ForumService(IUnitOfWork)
      qualifiedName:
        CSharp: BLL.ForumService.ForumService(DAL.UOW.IUnitOfWork)
        VB: BLL.ForumService.ForumService(DAL.UOW.IUnitOfWork)
      type: Constructor
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: .ctor
        path: ../BLL/ForumService.cs
        startLine: 15
      syntax:
        content:
          CSharp: public ForumService(IUnitOfWork dbContext)
          VB: Public Sub New(dbContext As IUnitOfWork)
        parameters:
        - id: dbContext
          type: DAL.UOW.IUnitOfWork
      overload: BLL.ForumService.#ctor*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BLL.ForumService.GetRubricsAsync
      commentId: M:BLL.ForumService.GetRubricsAsync
      language: CSharp
      name:
        CSharp: GetRubricsAsync()
        VB: GetRubricsAsync()
      nameWithType:
        CSharp: ForumService.GetRubricsAsync()
        VB: ForumService.GetRubricsAsync()
      qualifiedName:
        CSharp: BLL.ForumService.GetRubricsAsync()
        VB: BLL.ForumService.GetRubricsAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetRubricsAsync
        path: ../BLL/ForumService.cs
        startLine: 22
      syntax:
        content:
          CSharp: public async Task<IEnumerable<Rubric>> GetRubricsAsync()
          VB: Public Function GetRubricsAsync As Task(Of IEnumerable(Of Rubric))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Rubric}}
      overload: BLL.ForumService.GetRubricsAsync*
      implements:
      - BLL.IForumService.GetRubricsAsync
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.GetRubricByIdAsync(System.Int32)
      commentId: M:BLL.ForumService.GetRubricByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetRubricByIdAsync(Int32)
        VB: GetRubricByIdAsync(Int32)
      nameWithType:
        CSharp: ForumService.GetRubricByIdAsync(Int32)
        VB: ForumService.GetRubricByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.GetRubricByIdAsync(System.Int32)
        VB: BLL.ForumService.GetRubricByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetRubricByIdAsync
        path: ../BLL/ForumService.cs
        startLine: 31
      syntax:
        content:
          CSharp: public async Task<Rubric> GetRubricByIdAsync(int id)
          VB: Public Function GetRubricByIdAsync(id As Integer) As Task(Of Rubric)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Rubric}
      overload: BLL.ForumService.GetRubricByIdAsync*
      implements:
      - BLL.IForumService.GetRubricByIdAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.CreateRubricAsync(Domain.Entites.Rubric)
      commentId: M:BLL.ForumService.CreateRubricAsync(Domain.Entites.Rubric)
      language: CSharp
      name:
        CSharp: CreateRubricAsync(Rubric)
        VB: CreateRubricAsync(Rubric)
      nameWithType:
        CSharp: ForumService.CreateRubricAsync(Rubric)
        VB: ForumService.CreateRubricAsync(Rubric)
      qualifiedName:
        CSharp: BLL.ForumService.CreateRubricAsync(Domain.Entites.Rubric)
        VB: BLL.ForumService.CreateRubricAsync(Domain.Entites.Rubric)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: CreateRubricAsync
        path: ../BLL/ForumService.cs
        startLine: 47
      syntax:
        content:
          CSharp: public async Task<Rubric> CreateRubricAsync(Rubric newRubric)
          VB: Public Function CreateRubricAsync(newRubric As Rubric) As Task(Of Rubric)
        parameters:
        - id: newRubric
          type: Domain.Entites.Rubric
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Rubric}
      overload: BLL.ForumService.CreateRubricAsync*
      implements:
      - BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric)
      commentId: M:BLL.ForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric)
      language: CSharp
      name:
        CSharp: ModifyRubricAsync(Int32, Rubric)
        VB: ModifyRubricAsync(Int32, Rubric)
      nameWithType:
        CSharp: ForumService.ModifyRubricAsync(Int32, Rubric)
        VB: ForumService.ModifyRubricAsync(Int32, Rubric)
      qualifiedName:
        CSharp: BLL.ForumService.ModifyRubricAsync(System.Int32, Domain.Entites.Rubric)
        VB: BLL.ForumService.ModifyRubricAsync(System.Int32, Domain.Entites.Rubric)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: ModifyRubricAsync
        path: ../BLL/ForumService.cs
        startLine: 65
      syntax:
        content:
          CSharp: public async Task<Rubric> ModifyRubricAsync(int id, Rubric modifiedRubric)
          VB: Public Function ModifyRubricAsync(id As Integer, modifiedRubric As Rubric) As Task(Of Rubric)
        parameters:
        - id: id
          type: System.Int32
        - id: modifiedRubric
          type: Domain.Entites.Rubric
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Rubric}
      overload: BLL.ForumService.ModifyRubricAsync*
      implements:
      - BLL.IForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.DeleteRubricAsync(System.Int32)
      commentId: M:BLL.ForumService.DeleteRubricAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DeleteRubricAsync(Int32)
        VB: DeleteRubricAsync(Int32)
      nameWithType:
        CSharp: ForumService.DeleteRubricAsync(Int32)
        VB: ForumService.DeleteRubricAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.DeleteRubricAsync(System.Int32)
        VB: BLL.ForumService.DeleteRubricAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DeleteRubricAsync
        path: ../BLL/ForumService.cs
        startLine: 81
      syntax:
        content:
          CSharp: public async Task<bool> DeleteRubricAsync(int id)
          VB: Public Function DeleteRubricAsync(id As Integer) As Task(Of Boolean)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{System.Boolean}
      overload: BLL.ForumService.DeleteRubricAsync*
      implements:
      - BLL.IForumService.DeleteRubricAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.DetailRubricsAsync
      commentId: M:BLL.ForumService.DetailRubricsAsync
      language: CSharp
      name:
        CSharp: DetailRubricsAsync()
        VB: DetailRubricsAsync()
      nameWithType:
        CSharp: ForumService.DetailRubricsAsync()
        VB: ForumService.DetailRubricsAsync()
      qualifiedName:
        CSharp: BLL.ForumService.DetailRubricsAsync()
        VB: BLL.ForumService.DetailRubricsAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DetailRubricsAsync
        path: ../BLL/ForumService.cs
        startLine: 88
      syntax:
        content:
          CSharp: public async Task<IEnumerable<RubricDetail>> DetailRubricsAsync()
          VB: Public Function DetailRubricsAsync As Task(Of IEnumerable(Of RubricDetail))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.RubricDetail}}
      overload: BLL.ForumService.DetailRubricsAsync*
      implements:
      - BLL.IForumService.DetailRubricsAsync
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.DetailRubricByIdAsync(System.Int32)
      commentId: M:BLL.ForumService.DetailRubricByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DetailRubricByIdAsync(Int32)
        VB: DetailRubricByIdAsync(Int32)
      nameWithType:
        CSharp: ForumService.DetailRubricByIdAsync(Int32)
        VB: ForumService.DetailRubricByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.DetailRubricByIdAsync(System.Int32)
        VB: BLL.ForumService.DetailRubricByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DetailRubricByIdAsync
        path: ../BLL/ForumService.cs
        startLine: 104
      syntax:
        content:
          CSharp: public async Task<IEnumerable<RubricDetail>> DetailRubricByIdAsync(int id)
          VB: Public Function DetailRubricByIdAsync(id As Integer) As Task(Of IEnumerable(Of RubricDetail))
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.RubricDetail}}
      overload: BLL.ForumService.DetailRubricByIdAsync*
      implements:
      - BLL.IForumService.DetailRubricByIdAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.GetTopicsAsync
      commentId: M:BLL.ForumService.GetTopicsAsync
      language: CSharp
      name:
        CSharp: GetTopicsAsync()
        VB: GetTopicsAsync()
      nameWithType:
        CSharp: ForumService.GetTopicsAsync()
        VB: ForumService.GetTopicsAsync()
      qualifiedName:
        CSharp: BLL.ForumService.GetTopicsAsync()
        VB: BLL.ForumService.GetTopicsAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetTopicsAsync
        path: ../BLL/ForumService.cs
        startLine: 136
      syntax:
        content:
          CSharp: public async Task<IEnumerable<Topic>> GetTopicsAsync()
          VB: Public Function GetTopicsAsync As Task(Of IEnumerable(Of Topic))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Topic}}
      overload: BLL.ForumService.GetTopicsAsync*
      implements:
      - BLL.IForumService.GetTopicsAsync
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.GetTopicsByRubricIdAsync(System.Int32)
      commentId: M:BLL.ForumService.GetTopicsByRubricIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetTopicsByRubricIdAsync(Int32)
        VB: GetTopicsByRubricIdAsync(Int32)
      nameWithType:
        CSharp: ForumService.GetTopicsByRubricIdAsync(Int32)
        VB: ForumService.GetTopicsByRubricIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.GetTopicsByRubricIdAsync(System.Int32)
        VB: BLL.ForumService.GetTopicsByRubricIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetTopicsByRubricIdAsync
        path: ../BLL/ForumService.cs
        startLine: 144
      syntax:
        content:
          CSharp: public async Task<IEnumerable<Topic>> GetTopicsByRubricIdAsync(int rubricId)
          VB: Public Function GetTopicsByRubricIdAsync(rubricId As Integer) As Task(Of IEnumerable(Of Topic))
        parameters:
        - id: rubricId
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Topic}}
      overload: BLL.ForumService.GetTopicsByRubricIdAsync*
      implements:
      - BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.GetTopicByIdAsync(System.Int32)
      commentId: M:BLL.ForumService.GetTopicByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetTopicByIdAsync(Int32)
        VB: GetTopicByIdAsync(Int32)
      nameWithType:
        CSharp: ForumService.GetTopicByIdAsync(Int32)
        VB: ForumService.GetTopicByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.GetTopicByIdAsync(System.Int32)
        VB: BLL.ForumService.GetTopicByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetTopicByIdAsync
        path: ../BLL/ForumService.cs
        startLine: 153
      syntax:
        content:
          CSharp: public async Task<Topic> GetTopicByIdAsync(int id)
          VB: Public Function GetTopicByIdAsync(id As Integer) As Task(Of Topic)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Topic}
      overload: BLL.ForumService.GetTopicByIdAsync*
      implements:
      - BLL.IForumService.GetTopicByIdAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.CreateTopicAsync(Domain.Entites.Topic)
      commentId: M:BLL.ForumService.CreateTopicAsync(Domain.Entites.Topic)
      language: CSharp
      name:
        CSharp: CreateTopicAsync(Topic)
        VB: CreateTopicAsync(Topic)
      nameWithType:
        CSharp: ForumService.CreateTopicAsync(Topic)
        VB: ForumService.CreateTopicAsync(Topic)
      qualifiedName:
        CSharp: BLL.ForumService.CreateTopicAsync(Domain.Entites.Topic)
        VB: BLL.ForumService.CreateTopicAsync(Domain.Entites.Topic)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: CreateTopicAsync
        path: ../BLL/ForumService.cs
        startLine: 159
      syntax:
        content:
          CSharp: public async Task<Topic> CreateTopicAsync(Topic newTopic)
          VB: Public Function CreateTopicAsync(newTopic As Topic) As Task(Of Topic)
        parameters:
        - id: newTopic
          type: Domain.Entites.Topic
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Topic}
      overload: BLL.ForumService.CreateTopicAsync*
      implements:
      - BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic)
      commentId: M:BLL.ForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic)
      language: CSharp
      name:
        CSharp: ModifyTopicAsync(Int32, Topic)
        VB: ModifyTopicAsync(Int32, Topic)
      nameWithType:
        CSharp: ForumService.ModifyTopicAsync(Int32, Topic)
        VB: ForumService.ModifyTopicAsync(Int32, Topic)
      qualifiedName:
        CSharp: BLL.ForumService.ModifyTopicAsync(System.Int32, Domain.Entites.Topic)
        VB: BLL.ForumService.ModifyTopicAsync(System.Int32, Domain.Entites.Topic)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: ModifyTopicAsync
        path: ../BLL/ForumService.cs
        startLine: 173
      syntax:
        content:
          CSharp: public async Task<Topic> ModifyTopicAsync(int id, Topic updateTopic)
          VB: Public Function ModifyTopicAsync(id As Integer, updateTopic As Topic) As Task(Of Topic)
        parameters:
        - id: id
          type: System.Int32
        - id: updateTopic
          type: Domain.Entites.Topic
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Topic}
      overload: BLL.ForumService.ModifyTopicAsync*
      implements:
      - BLL.IForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.DeleteTopicAsync(System.Int32)
      commentId: M:BLL.ForumService.DeleteTopicAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DeleteTopicAsync(Int32)
        VB: DeleteTopicAsync(Int32)
      nameWithType:
        CSharp: ForumService.DeleteTopicAsync(Int32)
        VB: ForumService.DeleteTopicAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.DeleteTopicAsync(System.Int32)
        VB: BLL.ForumService.DeleteTopicAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DeleteTopicAsync
        path: ../BLL/ForumService.cs
        startLine: 187
      syntax:
        content:
          CSharp: public async Task<bool> DeleteTopicAsync(int id)
          VB: Public Function DeleteTopicAsync(id As Integer) As Task(Of Boolean)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{System.Boolean}
      overload: BLL.ForumService.DeleteTopicAsync*
      implements:
      - BLL.IForumService.DeleteTopicAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.DetailTopicsAsync
      commentId: M:BLL.ForumService.DetailTopicsAsync
      language: CSharp
      name:
        CSharp: DetailTopicsAsync()
        VB: DetailTopicsAsync()
      nameWithType:
        CSharp: ForumService.DetailTopicsAsync()
        VB: ForumService.DetailTopicsAsync()
      qualifiedName:
        CSharp: BLL.ForumService.DetailTopicsAsync()
        VB: BLL.ForumService.DetailTopicsAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DetailTopicsAsync
        path: ../BLL/ForumService.cs
        startLine: 230
      syntax:
        content:
          CSharp: public async Task<IEnumerable<TopicDetail>> DetailTopicsAsync()
          VB: Public Function DetailTopicsAsync As Task(Of IEnumerable(Of TopicDetail))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.TopicDetail}}
      overload: BLL.ForumService.DetailTopicsAsync*
      implements:
      - BLL.IForumService.DetailTopicsAsync
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.DetailTopicByIdAsync(System.Int32)
      commentId: M:BLL.ForumService.DetailTopicByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DetailTopicByIdAsync(Int32)
        VB: DetailTopicByIdAsync(Int32)
      nameWithType:
        CSharp: ForumService.DetailTopicByIdAsync(Int32)
        VB: ForumService.DetailTopicByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.DetailTopicByIdAsync(System.Int32)
        VB: BLL.ForumService.DetailTopicByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DetailTopicByIdAsync
        path: ../BLL/ForumService.cs
        startLine: 241
      syntax:
        content:
          CSharp: public async Task<IEnumerable<TopicDetail>> DetailTopicByIdAsync(int id)
          VB: Public Function DetailTopicByIdAsync(id As Integer) As Task(Of IEnumerable(Of TopicDetail))
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.TopicDetail}}
      overload: BLL.ForumService.DetailTopicByIdAsync*
      implements:
      - BLL.IForumService.DetailTopicByIdAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.GetRepliesAsync
      commentId: M:BLL.ForumService.GetRepliesAsync
      language: CSharp
      name:
        CSharp: GetRepliesAsync()
        VB: GetRepliesAsync()
      nameWithType:
        CSharp: ForumService.GetRepliesAsync()
        VB: ForumService.GetRepliesAsync()
      qualifiedName:
        CSharp: BLL.ForumService.GetRepliesAsync()
        VB: BLL.ForumService.GetRepliesAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetRepliesAsync
        path: ../BLL/ForumService.cs
        startLine: 271
      syntax:
        content:
          CSharp: public async Task<IEnumerable<Reply>> GetRepliesAsync()
          VB: Public Function GetRepliesAsync As Task(Of IEnumerable(Of Reply))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Reply}}
      overload: BLL.ForumService.GetRepliesAsync*
      implements:
      - BLL.IForumService.GetRepliesAsync
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.GetRepliesByTopicIdAsync(System.Int32)
      commentId: M:BLL.ForumService.GetRepliesByTopicIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetRepliesByTopicIdAsync(Int32)
        VB: GetRepliesByTopicIdAsync(Int32)
      nameWithType:
        CSharp: ForumService.GetRepliesByTopicIdAsync(Int32)
        VB: ForumService.GetRepliesByTopicIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.GetRepliesByTopicIdAsync(System.Int32)
        VB: BLL.ForumService.GetRepliesByTopicIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetRepliesByTopicIdAsync
        path: ../BLL/ForumService.cs
        startLine: 290
      syntax:
        content:
          CSharp: public async Task<IEnumerable<Reply>> GetRepliesByTopicIdAsync(int topicId)
          VB: Public Function GetRepliesByTopicIdAsync(topicId As Integer) As Task(Of IEnumerable(Of Reply))
        parameters:
        - id: topicId
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Reply}}
      overload: BLL.ForumService.GetRepliesByTopicIdAsync*
      implements:
      - BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.GetReplyByIdAsync(System.Int32)
      commentId: M:BLL.ForumService.GetReplyByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetReplyByIdAsync(Int32)
        VB: GetReplyByIdAsync(Int32)
      nameWithType:
        CSharp: ForumService.GetReplyByIdAsync(Int32)
        VB: ForumService.GetReplyByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.GetReplyByIdAsync(System.Int32)
        VB: BLL.ForumService.GetReplyByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetReplyByIdAsync
        path: ../BLL/ForumService.cs
        startLine: 320
      syntax:
        content:
          CSharp: public async Task<Reply> GetReplyByIdAsync(int id)
          VB: Public Function GetReplyByIdAsync(id As Integer) As Task(Of Reply)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Reply}
      overload: BLL.ForumService.GetReplyByIdAsync*
      implements:
      - BLL.IForumService.GetReplyByIdAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.CreateReplyAsync(Domain.Entites.Reply)
      commentId: M:BLL.ForumService.CreateReplyAsync(Domain.Entites.Reply)
      language: CSharp
      name:
        CSharp: CreateReplyAsync(Reply)
        VB: CreateReplyAsync(Reply)
      nameWithType:
        CSharp: ForumService.CreateReplyAsync(Reply)
        VB: ForumService.CreateReplyAsync(Reply)
      qualifiedName:
        CSharp: BLL.ForumService.CreateReplyAsync(Domain.Entites.Reply)
        VB: BLL.ForumService.CreateReplyAsync(Domain.Entites.Reply)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: CreateReplyAsync
        path: ../BLL/ForumService.cs
        startLine: 335
      syntax:
        content:
          CSharp: public async Task<Reply> CreateReplyAsync(Reply newReply)
          VB: Public Function CreateReplyAsync(newReply As Reply) As Task(Of Reply)
        parameters:
        - id: newReply
          type: Domain.Entites.Reply
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Reply}
      overload: BLL.ForumService.CreateReplyAsync*
      implements:
      - BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.ModifyReplyAsync(Domain.Entites.Reply)
      commentId: M:BLL.ForumService.ModifyReplyAsync(Domain.Entites.Reply)
      language: CSharp
      name:
        CSharp: ModifyReplyAsync(Reply)
        VB: ModifyReplyAsync(Reply)
      nameWithType:
        CSharp: ForumService.ModifyReplyAsync(Reply)
        VB: ForumService.ModifyReplyAsync(Reply)
      qualifiedName:
        CSharp: BLL.ForumService.ModifyReplyAsync(Domain.Entites.Reply)
        VB: BLL.ForumService.ModifyReplyAsync(Domain.Entites.Reply)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: ModifyReplyAsync
        path: ../BLL/ForumService.cs
        startLine: 353
      syntax:
        content:
          CSharp: public async Task<Reply> ModifyReplyAsync(Reply modifyreply)
          VB: Public Function ModifyReplyAsync(modifyreply As Reply) As Task(Of Reply)
        parameters:
        - id: modifyreply
          type: Domain.Entites.Reply
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Reply}
      overload: BLL.ForumService.ModifyReplyAsync*
      implements:
      - BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.ForumService.DeleteReplyAsync(System.Int32)
      commentId: M:BLL.ForumService.DeleteReplyAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DeleteReplyAsync(Int32)
        VB: DeleteReplyAsync(Int32)
      nameWithType:
        CSharp: ForumService.DeleteReplyAsync(Int32)
        VB: ForumService.DeleteReplyAsync(Int32)
      qualifiedName:
        CSharp: BLL.ForumService.DeleteReplyAsync(System.Int32)
        VB: BLL.ForumService.DeleteReplyAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DeleteReplyAsync
        path: ../BLL/ForumService.cs
        startLine: 372
      syntax:
        content:
          CSharp: public async Task<bool> DeleteReplyAsync(int id)
          VB: Public Function DeleteReplyAsync(id As Integer) As Task(Of Boolean)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{System.Boolean}
      overload: BLL.ForumService.DeleteReplyAsync*
      implements:
      - BLL.IForumService.DeleteReplyAsync(System.Int32)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
  - id: BLL.IAccountService
    commentId: T:BLL.IAccountService
    language: CSharp
    name:
      CSharp: IAccountService
      VB: IAccountService
    nameWithType:
      CSharp: IAccountService
      VB: IAccountService
    qualifiedName:
      CSharp: BLL.IAccountService
      VB: BLL.IAccountService
    type: Interface
    assemblies:
    - BLL
    namespace: BLL
    source:
      remote:
        path: BLL/IAccountService.cs
        branch: main
        repo: https://github.com/Deep-KALYAN/Forum.git
      id: IAccountService
      path: ../BLL/IAccountService.cs
      startLine: 6
    syntax:
      content:
        CSharp: public interface IAccountService
        VB: Public Interface IAccountService
    modifiers:
      CSharp:
      - public
      - interface
      VB:
      - Public
      - Interface
    items:
    - id: BLL.IAccountService.CreateUserAsync(Domain.Entites._User)
      commentId: M:BLL.IAccountService.CreateUserAsync(Domain.Entites._User)
      language: CSharp
      name:
        CSharp: CreateUserAsync(_User)
        VB: CreateUserAsync(_User)
      nameWithType:
        CSharp: IAccountService.CreateUserAsync(_User)
        VB: IAccountService.CreateUserAsync(_User)
      qualifiedName:
        CSharp: BLL.IAccountService.CreateUserAsync(Domain.Entites._User)
        VB: BLL.IAccountService.CreateUserAsync(Domain.Entites._User)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IAccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: CreateUserAsync
        path: ../BLL/IAccountService.cs
        startLine: 16
      summary: "\nCreate User \n"
      example: []
      syntax:
        content:
          CSharp: Task<_User> CreateUserAsync(_User newUser)
          VB: Function CreateUserAsync(newUser As _User) As Task(Of _User)
        parameters:
        - id: newUser
          type: Domain.Entites._User
          description: '_User(BO) '
        return:
          type: System.Threading.Tasks.Task{Domain.Entites._User}
          description: _User(BO) or throw new InsertSQLFailureException
      overload: BLL.IAccountService.CreateUserAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IAccountService.DeleteUserAsync(System.Int32)
      commentId: M:BLL.IAccountService.DeleteUserAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DeleteUserAsync(Int32)
        VB: DeleteUserAsync(Int32)
      nameWithType:
        CSharp: IAccountService.DeleteUserAsync(Int32)
        VB: IAccountService.DeleteUserAsync(Int32)
      qualifiedName:
        CSharp: BLL.IAccountService.DeleteUserAsync(System.Int32)
        VB: BLL.IAccountService.DeleteUserAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IAccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DeleteUserAsync
        path: ../BLL/IAccountService.cs
        startLine: 24
      summary: "\nDelete User Account by Id    \n"
      example: []
      syntax:
        content:
          CSharp: Task<bool> DeleteUserAsync(int id)
          VB: Function DeleteUserAsync(id As Integer) As Task(Of Boolean)
        parameters:
        - id: id
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{System.Boolean}
          description: bool
      overload: BLL.IAccountService.DeleteUserAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IAccountService.GetUserByIdAsync(System.Int32)
      commentId: M:BLL.IAccountService.GetUserByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetUserByIdAsync(Int32)
        VB: GetUserByIdAsync(Int32)
      nameWithType:
        CSharp: IAccountService.GetUserByIdAsync(Int32)
        VB: IAccountService.GetUserByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.IAccountService.GetUserByIdAsync(System.Int32)
        VB: BLL.IAccountService.GetUserByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IAccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetUserByIdAsync
        path: ../BLL/IAccountService.cs
        startLine: 31
      summary: "\nGet User Account By Id \n"
      example: []
      syntax:
        content:
          CSharp: Task<_User> GetUserByIdAsync(int id)
          VB: Function GetUserByIdAsync(id As Integer) As Task(Of _User)
        parameters:
        - id: id
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{Domain.Entites._User}
          description: IEnumerable _User(BO) or Throw New NotFoundException
      overload: BLL.IAccountService.GetUserByIdAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IAccountService.GetUsersAsync
      commentId: M:BLL.IAccountService.GetUsersAsync
      language: CSharp
      name:
        CSharp: GetUsersAsync()
        VB: GetUsersAsync()
      nameWithType:
        CSharp: IAccountService.GetUsersAsync()
        VB: IAccountService.GetUsersAsync()
      qualifiedName:
        CSharp: BLL.IAccountService.GetUsersAsync()
        VB: BLL.IAccountService.GetUsersAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IAccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetUsersAsync
        path: ../BLL/IAccountService.cs
        startLine: 38
      summary: "\nGet Users Accounts\n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<_User>> GetUsersAsync()
          VB: Function GetUsersAsync As Task(Of IEnumerable(Of _User))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites._User}}
          description: BO _User or Throw New NotFoundException
      overload: BLL.IAccountService.GetUsersAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IAccountService.GetUserByloginNameAsync(System.String)
      commentId: M:BLL.IAccountService.GetUserByloginNameAsync(System.String)
      language: CSharp
      name:
        CSharp: GetUserByloginNameAsync(String)
        VB: GetUserByloginNameAsync(String)
      nameWithType:
        CSharp: IAccountService.GetUserByloginNameAsync(String)
        VB: IAccountService.GetUserByloginNameAsync(String)
      qualifiedName:
        CSharp: BLL.IAccountService.GetUserByloginNameAsync(System.String)
        VB: BLL.IAccountService.GetUserByloginNameAsync(System.String)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IAccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetUserByloginNameAsync
        path: ../BLL/IAccountService.cs
        startLine: 45
      summary: "\nGet User Account by LoginName\n"
      example: []
      syntax:
        content:
          CSharp: Task<_User> GetUserByloginNameAsync(string loginname)
          VB: Function GetUserByloginNameAsync(loginname As String) As Task(Of _User)
        parameters:
        - id: loginname
          type: System.String
          description: LoginName
        return:
          type: System.Threading.Tasks.Task{Domain.Entites._User}
          description: BO _User or Throw New NotFoundException
      overload: BLL.IAccountService.GetUserByloginNameAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IAccountService.ModifyUserAsync(Domain.Entites._User)
      commentId: M:BLL.IAccountService.ModifyUserAsync(Domain.Entites._User)
      language: CSharp
      name:
        CSharp: ModifyUserAsync(_User)
        VB: ModifyUserAsync(_User)
      nameWithType:
        CSharp: IAccountService.ModifyUserAsync(_User)
        VB: IAccountService.ModifyUserAsync(_User)
      qualifiedName:
        CSharp: BLL.IAccountService.ModifyUserAsync(Domain.Entites._User)
        VB: BLL.IAccountService.ModifyUserAsync(Domain.Entites._User)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IAccountService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: ModifyUserAsync
        path: ../BLL/IAccountService.cs
        startLine: 52
      summary: "\nModify User Account\n"
      example: []
      syntax:
        content:
          CSharp: Task<_User> ModifyUserAsync(_User modifiedUser)
          VB: Function ModifyUserAsync(modifiedUser As _User) As Task(Of _User)
        parameters:
        - id: modifiedUser
          type: Domain.Entites._User
          description: _User(BO)
        return:
          type: System.Threading.Tasks.Task{Domain.Entites._User}
          description: BO _User or Throw New NotFoundException
      overload: BLL.IAccountService.ModifyUserAsync*
      modifiers:
        CSharp: []
        VB: []
  - id: BLL.IForumService
    commentId: T:BLL.IForumService
    language: CSharp
    name:
      CSharp: IForumService
      VB: IForumService
    nameWithType:
      CSharp: IForumService
      VB: IForumService
    qualifiedName:
      CSharp: BLL.IForumService
      VB: BLL.IForumService
    type: Interface
    assemblies:
    - BLL
    namespace: BLL
    source:
      remote:
        path: BLL/IForumService.cs
        branch: main
        repo: https://github.com/Deep-KALYAN/Forum.git
      id: IForumService
      path: ../BLL/IForumService.cs
      startLine: 6
    syntax:
      content:
        CSharp: public interface IForumService
        VB: Public Interface IForumService
    modifiers:
      CSharp:
      - public
      - interface
      VB:
      - Public
      - Interface
    items:
    - id: BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply)
      commentId: M:BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply)
      language: CSharp
      name:
        CSharp: CreateReplyAsync(Reply)
        VB: CreateReplyAsync(Reply)
      nameWithType:
        CSharp: IForumService.CreateReplyAsync(Reply)
        VB: IForumService.CreateReplyAsync(Reply)
      qualifiedName:
        CSharp: BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply)
        VB: BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: CreateReplyAsync
        path: ../BLL/IForumService.cs
        startLine: 13
      summary: "\nTo Create Reply \n"
      example: []
      syntax:
        content:
          CSharp: Task<Reply> CreateReplyAsync(Reply reply)
          VB: Function CreateReplyAsync(reply As Reply) As Task(Of Reply)
        parameters:
        - id: reply
          type: Domain.Entites.Reply
          description: ''
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Reply}
          description: BO Reply or Null
      overload: BLL.IForumService.CreateReplyAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric)
      commentId: M:BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric)
      language: CSharp
      name:
        CSharp: CreateRubricAsync(Rubric)
        VB: CreateRubricAsync(Rubric)
      nameWithType:
        CSharp: IForumService.CreateRubricAsync(Rubric)
        VB: IForumService.CreateRubricAsync(Rubric)
      qualifiedName:
        CSharp: BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric)
        VB: BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: CreateRubricAsync
        path: ../BLL/IForumService.cs
        startLine: 20
      summary: "\nTo Create Rubric \n"
      example: []
      syntax:
        content:
          CSharp: Task<Rubric> CreateRubricAsync(Rubric rubric)
          VB: Function CreateRubricAsync(rubric As Rubric) As Task(Of Rubric)
        parameters:
        - id: rubric
          type: Domain.Entites.Rubric
          description: ''
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Rubric}
          description: BO Rubric or Null
      overload: BLL.IForumService.CreateRubricAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic)
      commentId: M:BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic)
      language: CSharp
      name:
        CSharp: CreateTopicAsync(Topic)
        VB: CreateTopicAsync(Topic)
      nameWithType:
        CSharp: IForumService.CreateTopicAsync(Topic)
        VB: IForumService.CreateTopicAsync(Topic)
      qualifiedName:
        CSharp: BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic)
        VB: BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: CreateTopicAsync
        path: ../BLL/IForumService.cs
        startLine: 27
      summary: "\nTo Create Topic \n"
      example: []
      syntax:
        content:
          CSharp: Task<Topic> CreateTopicAsync(Topic topic)
          VB: Function CreateTopicAsync(topic As Topic) As Task(Of Topic)
        parameters:
        - id: topic
          type: Domain.Entites.Topic
          description: ''
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Topic}
          description: BO Topic or Null
      overload: BLL.IForumService.CreateTopicAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.DeleteReplyAsync(System.Int32)
      commentId: M:BLL.IForumService.DeleteReplyAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DeleteReplyAsync(Int32)
        VB: DeleteReplyAsync(Int32)
      nameWithType:
        CSharp: IForumService.DeleteReplyAsync(Int32)
        VB: IForumService.DeleteReplyAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.DeleteReplyAsync(System.Int32)
        VB: BLL.IForumService.DeleteReplyAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DeleteReplyAsync
        path: ../BLL/IForumService.cs
        startLine: 36
      summary: "\nTo Delete Reply by Reply Id\nIf Deleted, Text Change as &quot;message have been deleted by admin&quot;\n"
      example: []
      syntax:
        content:
          CSharp: Task<bool> DeleteReplyAsync(int id)
          VB: Function DeleteReplyAsync(id As Integer) As Task(Of Boolean)
        parameters:
        - id: id
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{System.Boolean}
          description: boolean
      overload: BLL.IForumService.DeleteReplyAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.DeleteRubricAsync(System.Int32)
      commentId: M:BLL.IForumService.DeleteRubricAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DeleteRubricAsync(Int32)
        VB: DeleteRubricAsync(Int32)
      nameWithType:
        CSharp: IForumService.DeleteRubricAsync(Int32)
        VB: IForumService.DeleteRubricAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.DeleteRubricAsync(System.Int32)
        VB: BLL.IForumService.DeleteRubricAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DeleteRubricAsync
        path: ../BLL/IForumService.cs
        startLine: 44
      summary: "\nTo Delete Rubric by Id\n"
      example: []
      syntax:
        content:
          CSharp: Task<bool> DeleteRubricAsync(int id)
          VB: Function DeleteRubricAsync(id As Integer) As Task(Of Boolean)
        parameters:
        - id: id
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{System.Boolean}
          description: boolean
      overload: BLL.IForumService.DeleteRubricAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.DeleteTopicAsync(System.Int32)
      commentId: M:BLL.IForumService.DeleteTopicAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DeleteTopicAsync(Int32)
        VB: DeleteTopicAsync(Int32)
      nameWithType:
        CSharp: IForumService.DeleteTopicAsync(Int32)
        VB: IForumService.DeleteTopicAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.DeleteTopicAsync(System.Int32)
        VB: BLL.IForumService.DeleteTopicAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DeleteTopicAsync
        path: ../BLL/IForumService.cs
        startLine: 52
      summary: "\nTo Delete Topic  by Id,\nAll Concerning Replies will Delete also\n"
      example: []
      syntax:
        content:
          CSharp: Task<bool> DeleteTopicAsync(int id)
          VB: Function DeleteTopicAsync(id As Integer) As Task(Of Boolean)
        parameters:
        - id: id
          type: System.Int32
          description: ''
        return:
          type: System.Threading.Tasks.Task{System.Boolean}
          description: boolean
      overload: BLL.IForumService.DeleteTopicAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.GetRepliesAsync
      commentId: M:BLL.IForumService.GetRepliesAsync
      language: CSharp
      name:
        CSharp: GetRepliesAsync()
        VB: GetRepliesAsync()
      nameWithType:
        CSharp: IForumService.GetRepliesAsync()
        VB: IForumService.GetRepliesAsync()
      qualifiedName:
        CSharp: BLL.IForumService.GetRepliesAsync()
        VB: BLL.IForumService.GetRepliesAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetRepliesAsync
        path: ../BLL/IForumService.cs
        startLine: 58
      summary: "\nTo Get All Replies \n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<Reply>> GetRepliesAsync()
          VB: Function GetRepliesAsync As Task(Of IEnumerable(Of Reply))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Reply}}
          description: BO Reply IEnumerable
      overload: BLL.IForumService.GetRepliesAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32)
      commentId: M:BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetRepliesByTopicIdAsync(Int32)
        VB: GetRepliesByTopicIdAsync(Int32)
      nameWithType:
        CSharp: IForumService.GetRepliesByTopicIdAsync(Int32)
        VB: IForumService.GetRepliesByTopicIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32)
        VB: BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetRepliesByTopicIdAsync
        path: ../BLL/IForumService.cs
        startLine: 65
      summary: "\nTo Get Replies of Concerning Topic by Topic Id \n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<Reply>> GetRepliesByTopicIdAsync(int topicId)
          VB: Function GetRepliesByTopicIdAsync(topicId As Integer) As Task(Of IEnumerable(Of Reply))
        parameters:
        - id: topicId
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Reply}}
          description: BO Reply IEnumerable
      overload: BLL.IForumService.GetRepliesByTopicIdAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.GetReplyByIdAsync(System.Int32)
      commentId: M:BLL.IForumService.GetReplyByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetReplyByIdAsync(Int32)
        VB: GetReplyByIdAsync(Int32)
      nameWithType:
        CSharp: IForumService.GetReplyByIdAsync(Int32)
        VB: IForumService.GetReplyByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.GetReplyByIdAsync(System.Int32)
        VB: BLL.IForumService.GetReplyByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetReplyByIdAsync
        path: ../BLL/IForumService.cs
        startLine: 74
      summary: "\nTo Get Reply by Id  \n"
      example: []
      syntax:
        content:
          CSharp: Task<Reply> GetReplyByIdAsync(int id)
          VB: Function GetReplyByIdAsync(id As Integer) As Task(Of Reply)
        parameters:
        - id: id
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Reply}
          description: BO Reply
      overload: BLL.IForumService.GetReplyByIdAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.GetRubricByIdAsync(System.Int32)
      commentId: M:BLL.IForumService.GetRubricByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetRubricByIdAsync(Int32)
        VB: GetRubricByIdAsync(Int32)
      nameWithType:
        CSharp: IForumService.GetRubricByIdAsync(Int32)
        VB: IForumService.GetRubricByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.GetRubricByIdAsync(System.Int32)
        VB: BLL.IForumService.GetRubricByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetRubricByIdAsync
        path: ../BLL/IForumService.cs
        startLine: 80
      summary: "\nTo Get Rubric by Id\n"
      example: []
      syntax:
        content:
          CSharp: Task<Rubric> GetRubricByIdAsync(int id)
          VB: Function GetRubricByIdAsync(id As Integer) As Task(Of Rubric)
        parameters:
        - id: id
          type: System.Int32
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Rubric}
          description: BO Rubric
      overload: BLL.IForumService.GetRubricByIdAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.GetRubricsAsync
      commentId: M:BLL.IForumService.GetRubricsAsync
      language: CSharp
      name:
        CSharp: GetRubricsAsync()
        VB: GetRubricsAsync()
      nameWithType:
        CSharp: IForumService.GetRubricsAsync()
        VB: IForumService.GetRubricsAsync()
      qualifiedName:
        CSharp: BLL.IForumService.GetRubricsAsync()
        VB: BLL.IForumService.GetRubricsAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetRubricsAsync
        path: ../BLL/IForumService.cs
        startLine: 86
      summary: "\nTo Get All Rubrics  \n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<Rubric>> GetRubricsAsync()
          VB: Function GetRubricsAsync As Task(Of IEnumerable(Of Rubric))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Rubric}}
          description: BO Rubric IEnumerable
      overload: BLL.IForumService.GetRubricsAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.GetTopicByIdAsync(System.Int32)
      commentId: M:BLL.IForumService.GetTopicByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetTopicByIdAsync(Int32)
        VB: GetTopicByIdAsync(Int32)
      nameWithType:
        CSharp: IForumService.GetTopicByIdAsync(Int32)
        VB: IForumService.GetTopicByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.GetTopicByIdAsync(System.Int32)
        VB: BLL.IForumService.GetTopicByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetTopicByIdAsync
        path: ../BLL/IForumService.cs
        startLine: 93
      summary: "\nTo Get Topic by Id \n"
      example: []
      syntax:
        content:
          CSharp: Task<Topic> GetTopicByIdAsync(int id)
          VB: Function GetTopicByIdAsync(id As Integer) As Task(Of Topic)
        parameters:
        - id: id
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Topic}
          description: BO Topic
      overload: BLL.IForumService.GetTopicByIdAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.GetTopicsAsync
      commentId: M:BLL.IForumService.GetTopicsAsync
      language: CSharp
      name:
        CSharp: GetTopicsAsync()
        VB: GetTopicsAsync()
      nameWithType:
        CSharp: IForumService.GetTopicsAsync()
        VB: IForumService.GetTopicsAsync()
      qualifiedName:
        CSharp: BLL.IForumService.GetTopicsAsync()
        VB: BLL.IForumService.GetTopicsAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetTopicsAsync
        path: ../BLL/IForumService.cs
        startLine: 99
      summary: "\nTo Get All Topics\n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<Topic>> GetTopicsAsync()
          VB: Function GetTopicsAsync As Task(Of IEnumerable(Of Topic))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Topic}}
          description: BO Topic IEnumerable
      overload: BLL.IForumService.GetTopicsAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32)
      commentId: M:BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: GetTopicsByRubricIdAsync(Int32)
        VB: GetTopicsByRubricIdAsync(Int32)
      nameWithType:
        CSharp: IForumService.GetTopicsByRubricIdAsync(Int32)
        VB: IForumService.GetTopicsByRubricIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32)
        VB: BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GetTopicsByRubricIdAsync
        path: ../BLL/IForumService.cs
        startLine: 106
      summary: "\nTo Get Topics of Concerning Rubric by Rubric Id\n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<Topic>> GetTopicsByRubricIdAsync(int rubricId)
          VB: Function GetTopicsByRubricIdAsync(rubricId As Integer) As Task(Of IEnumerable(Of Topic))
        parameters:
        - id: rubricId
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Topic}}
          description: BO Topic IEnumerable
      overload: BLL.IForumService.GetTopicsByRubricIdAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply)
      commentId: M:BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply)
      language: CSharp
      name:
        CSharp: ModifyReplyAsync(Reply)
        VB: ModifyReplyAsync(Reply)
      nameWithType:
        CSharp: IForumService.ModifyReplyAsync(Reply)
        VB: IForumService.ModifyReplyAsync(Reply)
      qualifiedName:
        CSharp: BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply)
        VB: BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: ModifyReplyAsync
        path: ../BLL/IForumService.cs
        startLine: 113
      summary: "\nTo Modify Reply\n"
      example: []
      syntax:
        content:
          CSharp: Task<Reply> ModifyReplyAsync(Reply reply)
          VB: Function ModifyReplyAsync(reply As Reply) As Task(Of Reply)
        parameters:
        - id: reply
          type: Domain.Entites.Reply
          description: BO Reply
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Reply}
          description: BO Reply or Null
      overload: BLL.IForumService.ModifyReplyAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric)
      commentId: M:BLL.IForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric)
      language: CSharp
      name:
        CSharp: ModifyRubricAsync(Int32, Rubric)
        VB: ModifyRubricAsync(Int32, Rubric)
      nameWithType:
        CSharp: IForumService.ModifyRubricAsync(Int32, Rubric)
        VB: IForumService.ModifyRubricAsync(Int32, Rubric)
      qualifiedName:
        CSharp: BLL.IForumService.ModifyRubricAsync(System.Int32, Domain.Entites.Rubric)
        VB: BLL.IForumService.ModifyRubricAsync(System.Int32, Domain.Entites.Rubric)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: ModifyRubricAsync
        path: ../BLL/IForumService.cs
        startLine: 121
      summary: "\nTo Modify Rubric \n"
      example: []
      syntax:
        content:
          CSharp: Task<Rubric> ModifyRubricAsync(int id, Rubric rubric)
          VB: Function ModifyRubricAsync(id As Integer, rubric As Rubric) As Task(Of Rubric)
        parameters:
        - id: id
          type: System.Int32
          description: id
        - id: rubric
          type: Domain.Entites.Rubric
          description: BO Rubric
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Rubric}
          description: BO Rubric or Null
      overload: BLL.IForumService.ModifyRubricAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic)
      commentId: M:BLL.IForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic)
      language: CSharp
      name:
        CSharp: ModifyTopicAsync(Int32, Topic)
        VB: ModifyTopicAsync(Int32, Topic)
      nameWithType:
        CSharp: IForumService.ModifyTopicAsync(Int32, Topic)
        VB: IForumService.ModifyTopicAsync(Int32, Topic)
      qualifiedName:
        CSharp: BLL.IForumService.ModifyTopicAsync(System.Int32, Domain.Entites.Topic)
        VB: BLL.IForumService.ModifyTopicAsync(System.Int32, Domain.Entites.Topic)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: ModifyTopicAsync
        path: ../BLL/IForumService.cs
        startLine: 129
      summary: "\nTo Modify Topic \n"
      example: []
      syntax:
        content:
          CSharp: Task<Topic> ModifyTopicAsync(int id, Topic topic)
          VB: Function ModifyTopicAsync(id As Integer, topic As Topic) As Task(Of Topic)
        parameters:
        - id: id
          type: System.Int32
          description: id
        - id: topic
          type: Domain.Entites.Topic
          description: BO Topic
        return:
          type: System.Threading.Tasks.Task{Domain.Entites.Topic}
          description: BO Topic or Null
      overload: BLL.IForumService.ModifyTopicAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.DetailTopicsAsync
      commentId: M:BLL.IForumService.DetailTopicsAsync
      language: CSharp
      name:
        CSharp: DetailTopicsAsync()
        VB: DetailTopicsAsync()
      nameWithType:
        CSharp: IForumService.DetailTopicsAsync()
        VB: IForumService.DetailTopicsAsync()
      qualifiedName:
        CSharp: BLL.IForumService.DetailTopicsAsync()
        VB: BLL.IForumService.DetailTopicsAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DetailTopicsAsync
        path: ../BLL/IForumService.cs
        startLine: 140
      summary: "\nTo Get All Replies with Detail (by View TOPIC_DETAIL )\n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<TopicDetail>> DetailTopicsAsync()
          VB: Function DetailTopicsAsync As Task(Of IEnumerable(Of TopicDetail))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.TopicDetail}}
          description: BO TopicDetail IEnumerable
      overload: BLL.IForumService.DetailTopicsAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.DetailTopicByIdAsync(System.Int32)
      commentId: M:BLL.IForumService.DetailTopicByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DetailTopicByIdAsync(Int32)
        VB: DetailTopicByIdAsync(Int32)
      nameWithType:
        CSharp: IForumService.DetailTopicByIdAsync(Int32)
        VB: IForumService.DetailTopicByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.DetailTopicByIdAsync(System.Int32)
        VB: BLL.IForumService.DetailTopicByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DetailTopicByIdAsync
        path: ../BLL/IForumService.cs
        startLine: 147
      summary: "\nTo Get Replies with Detail by Topic Id (by View TOPIC_DETAIL )\n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<TopicDetail>> DetailTopicByIdAsync(int id)
          VB: Function DetailTopicByIdAsync(id As Integer) As Task(Of IEnumerable(Of TopicDetail))
        parameters:
        - id: id
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.TopicDetail}}
          description: BO TopicDetail IEnumerable
      overload: BLL.IForumService.DetailTopicByIdAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.DetailRubricsAsync
      commentId: M:BLL.IForumService.DetailRubricsAsync
      language: CSharp
      name:
        CSharp: DetailRubricsAsync()
        VB: DetailRubricsAsync()
      nameWithType:
        CSharp: IForumService.DetailRubricsAsync()
        VB: IForumService.DetailRubricsAsync()
      qualifiedName:
        CSharp: BLL.IForumService.DetailRubricsAsync()
        VB: BLL.IForumService.DetailRubricsAsync()
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DetailRubricsAsync
        path: ../BLL/IForumService.cs
        startLine: 156
      summary: "\nTo Get All Topics with Detail (by View RUBRICS_DETAIL )\n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<RubricDetail>> DetailRubricsAsync()
          VB: Function DetailRubricsAsync As Task(Of IEnumerable(Of RubricDetail))
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.RubricDetail}}
          description: BO RubricDetail IEnumerable
      overload: BLL.IForumService.DetailRubricsAsync*
      modifiers:
        CSharp: []
        VB: []
    - id: BLL.IForumService.DetailRubricByIdAsync(System.Int32)
      commentId: M:BLL.IForumService.DetailRubricByIdAsync(System.Int32)
      language: CSharp
      name:
        CSharp: DetailRubricByIdAsync(Int32)
        VB: DetailRubricByIdAsync(Int32)
      nameWithType:
        CSharp: IForumService.DetailRubricByIdAsync(Int32)
        VB: IForumService.DetailRubricByIdAsync(Int32)
      qualifiedName:
        CSharp: BLL.IForumService.DetailRubricByIdAsync(System.Int32)
        VB: BLL.IForumService.DetailRubricByIdAsync(System.Int32)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/IForumService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: DetailRubricByIdAsync
        path: ../BLL/IForumService.cs
        startLine: 163
      summary: "\nTo Get Topics with Detail by Rubric Id (by View RUBRICS_DETAIL )\n"
      example: []
      syntax:
        content:
          CSharp: Task<IEnumerable<RubricDetail>> DetailRubricByIdAsync(int id)
          VB: Function DetailRubricByIdAsync(id As Integer) As Task(Of IEnumerable(Of RubricDetail))
        parameters:
        - id: id
          type: System.Int32
          description: id
        return:
          type: System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.RubricDetail}}
          description: BO RubricDetail IEnumerable
      overload: BLL.IForumService.DetailRubricByIdAsync*
      modifiers:
        CSharp: []
        VB: []
  - id: BLL.ISecurityService
    commentId: T:BLL.ISecurityService
    language: CSharp
    name:
      CSharp: ISecurityService
      VB: ISecurityService
    nameWithType:
      CSharp: ISecurityService
      VB: ISecurityService
    qualifiedName:
      CSharp: BLL.ISecurityService
      VB: BLL.ISecurityService
    type: Interface
    assemblies:
    - BLL
    namespace: BLL
    source:
      remote:
        path: BLL/ISecurityService.cs
        branch: main
        repo: https://github.com/Deep-KALYAN/Forum.git
      id: ISecurityService
      path: ../BLL/ISecurityService.cs
      startLine: 5
    syntax:
      content:
        CSharp: public interface ISecurityService
        VB: Public Interface ISecurityService
    modifiers:
      CSharp:
      - public
      - interface
      VB:
      - Public
      - Interface
    items:
    - id: BLL.ISecurityService.SigningAsync(System.String,System.String)
      commentId: M:BLL.ISecurityService.SigningAsync(System.String,System.String)
      language: CSharp
      name:
        CSharp: SigningAsync(String, String)
        VB: SigningAsync(String, String)
      nameWithType:
        CSharp: ISecurityService.SigningAsync(String, String)
        VB: ISecurityService.SigningAsync(String, String)
      qualifiedName:
        CSharp: BLL.ISecurityService.SigningAsync(System.String, System.String)
        VB: BLL.ISecurityService.SigningAsync(System.String, System.String)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/ISecurityService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: SigningAsync
        path: ../BLL/ISecurityService.cs
        startLine: 13
      summary: "\nGenerate the Token \n"
      example: []
      syntax:
        content:
          CSharp: Task<string> SigningAsync(string login_name, string password)
          VB: Function SigningAsync(login_name As String, password As String) As Task(Of String)
        parameters:
        - id: login_name
          type: System.String
        - id: password
          type: System.String
          description: password
        return:
          type: System.Threading.Tasks.Task{System.String}
          description: JWT Token or Throw ForbiddenAccessException or Throw AuthentificationFailException
      overload: BLL.ISecurityService.SigningAsync*
      modifiers:
        CSharp: []
        VB: []
  - id: BLL.SecurityService
    commentId: T:BLL.SecurityService
    language: CSharp
    name:
      CSharp: SecurityService
      VB: SecurityService
    nameWithType:
      CSharp: SecurityService
      VB: SecurityService
    qualifiedName:
      CSharp: BLL.SecurityService
      VB: BLL.SecurityService
    type: Class
    assemblies:
    - BLL
    namespace: BLL
    source:
      remote:
        path: BLL/SecurityService.cs
        branch: main
        repo: https://github.com/Deep-KALYAN/Forum.git
      id: SecurityService
      path: ../BLL/SecurityService.cs
      startLine: 15
    syntax:
      content:
        CSharp: 'class SecurityService : ISecurityService'
        VB: >-
          Class SecurityService

              Implements ISecurityService
    inheritance:
    - System.Object
    implements:
    - BLL.ISecurityService
    inheritedMembers:
    - System.Object.Equals(System.Object)
    - System.Object.Equals(System.Object,System.Object)
    - System.Object.GetHashCode
    - System.Object.GetType
    - System.Object.MemberwiseClone
    - System.Object.ReferenceEquals(System.Object,System.Object)
    - System.Object.ToString
    modifiers:
      CSharp:
      - class
      VB:
      - Class
    items:
    - id: BLL.SecurityService._configuration
      commentId: F:BLL.SecurityService._configuration
      language: CSharp
      name:
        CSharp: _configuration
        VB: _configuration
      nameWithType:
        CSharp: SecurityService._configuration
        VB: SecurityService._configuration
      qualifiedName:
        CSharp: BLL.SecurityService._configuration
        VB: BLL.SecurityService._configuration
      type: Field
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/SecurityService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: _configuration
        path: ../BLL/SecurityService.cs
        startLine: 17
      syntax:
        content:
          CSharp: readonly IConfiguration _configuration
          VB: ReadOnly _configuration As IConfiguration
        return:
          type: Microsoft.Extensions.Configuration.IConfiguration
      modifiers:
        CSharp:
        - readonly
        VB:
        - ReadOnly
    - id: BLL.SecurityService._accountService
      commentId: F:BLL.SecurityService._accountService
      language: CSharp
      name:
        CSharp: _accountService
        VB: _accountService
      nameWithType:
        CSharp: SecurityService._accountService
        VB: SecurityService._accountService
      qualifiedName:
        CSharp: BLL.SecurityService._accountService
        VB: BLL.SecurityService._accountService
      type: Field
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/SecurityService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: _accountService
        path: ../BLL/SecurityService.cs
        startLine: 19
      syntax:
        content:
          CSharp: readonly IAccountService _accountService
          VB: ReadOnly _accountService As IAccountService
        return:
          type: BLL.IAccountService
      modifiers:
        CSharp:
        - readonly
        VB:
        - ReadOnly
    - id: BLL.SecurityService.#ctor(Microsoft.Extensions.Configuration.IConfiguration,BLL.IAccountService)
      commentId: M:BLL.SecurityService.#ctor(Microsoft.Extensions.Configuration.IConfiguration,BLL.IAccountService)
      language: CSharp
      name:
        CSharp: SecurityService(IConfiguration, IAccountService)
        VB: SecurityService(IConfiguration, IAccountService)
      nameWithType:
        CSharp: SecurityService.SecurityService(IConfiguration, IAccountService)
        VB: SecurityService.SecurityService(IConfiguration, IAccountService)
      qualifiedName:
        CSharp: BLL.SecurityService.SecurityService(Microsoft.Extensions.Configuration.IConfiguration, BLL.IAccountService)
        VB: BLL.SecurityService.SecurityService(Microsoft.Extensions.Configuration.IConfiguration, BLL.IAccountService)
      type: Constructor
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/SecurityService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: .ctor
        path: ../BLL/SecurityService.cs
        startLine: 20
      syntax:
        content:
          CSharp: public SecurityService(IConfiguration configuration, IAccountService accountService)
          VB: Public Sub New(configuration As IConfiguration, accountService As IAccountService)
        parameters:
        - id: configuration
          type: Microsoft.Extensions.Configuration.IConfiguration
        - id: accountService
          type: BLL.IAccountService
      overload: BLL.SecurityService.#ctor*
      modifiers:
        CSharp:
        - public
        VB:
        - Public
    - id: BLL.SecurityService.SigningAsync(System.String,System.String)
      commentId: M:BLL.SecurityService.SigningAsync(System.String,System.String)
      language: CSharp
      name:
        CSharp: SigningAsync(String, String)
        VB: SigningAsync(String, String)
      nameWithType:
        CSharp: SecurityService.SigningAsync(String, String)
        VB: SecurityService.SigningAsync(String, String)
      qualifiedName:
        CSharp: BLL.SecurityService.SigningAsync(System.String, System.String)
        VB: BLL.SecurityService.SigningAsync(System.String, System.String)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/SecurityService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: SigningAsync
        path: ../BLL/SecurityService.cs
        startLine: 31
      syntax:
        content:
          CSharp: public async Task<string> SigningAsync(string login_name, string password)
          VB: Public Function SigningAsync(login_name As String, password As String) As Task(Of String)
        parameters:
        - id: login_name
          type: System.String
        - id: password
          type: System.String
        return:
          type: System.Threading.Tasks.Task{System.String}
      overload: BLL.SecurityService.SigningAsync*
      implements:
      - BLL.ISecurityService.SigningAsync(System.String,System.String)
      modifiers:
        CSharp:
        - public
        - async
        VB:
        - Public
    - id: BLL.SecurityService.GenerateJwtToken(System.String,System.Collections.Generic.List{System.String},System.String)
      commentId: M:BLL.SecurityService.GenerateJwtToken(System.String,System.Collections.Generic.List{System.String},System.String)
      language: CSharp
      name:
        CSharp: GenerateJwtToken(String, List<String>, String)
        VB: GenerateJwtToken(String, List(Of String), String)
      nameWithType:
        CSharp: SecurityService.GenerateJwtToken(String, List<String>, String)
        VB: SecurityService.GenerateJwtToken(String, List(Of String), String)
      qualifiedName:
        CSharp: BLL.SecurityService.GenerateJwtToken(System.String, System.Collections.Generic.List<System.String>, System.String)
        VB: BLL.SecurityService.GenerateJwtToken(System.String, System.Collections.Generic.List(Of System.String), System.String)
      type: Method
      assemblies:
      - BLL
      namespace: BLL
      source:
        remote:
          path: BLL/SecurityService.cs
          branch: main
          repo: https://github.com/Deep-KALYAN/Forum.git
        id: GenerateJwtToken
        path: ../BLL/SecurityService.cs
        startLine: 64
      syntax:
        content:
          CSharp: string GenerateJwtToken(string login_name, List<string> roles, string id)
          VB: Function GenerateJwtToken(login_name As String, roles As List(Of String), id As String) As String
        parameters:
        - id: login_name
          type: System.String
        - id: roles
          type: System.Collections.Generic.List{System.String}
        - id: id
          type: System.String
        return:
          type: System.String
      overload: BLL.SecurityService.GenerateJwtToken*
      modifiers:
        CSharp: []
        VB: []
references:
  System:
    name:
      CSharp:
      - name: System
        nameWithType: System
        qualifiedName: System
        isExternal: true
      VB:
      - name: System
        nameWithType: System
        qualifiedName: System
    isDefinition: true
    commentId: N:System
  System.Object:
    name:
      CSharp:
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      VB:
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
    isDefinition: true
    parent: System
    commentId: T:System.Object
  System.Object.Equals(System.Object):
    name:
      CSharp:
      - id: System.Object.Equals(System.Object)
        name: Equals
        nameWithType: Object.Equals
        qualifiedName: System.Object.Equals
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: System.Object.Equals(System.Object)
        name: Equals
        nameWithType: Object.Equals
        qualifiedName: System.Object.Equals
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: System.Object
    commentId: M:System.Object.Equals(System.Object)
  System.Object.Equals(System.Object,System.Object):
    name:
      CSharp:
      - id: System.Object.Equals(System.Object,System.Object)
        name: Equals
        nameWithType: Object.Equals
        qualifiedName: System.Object.Equals
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: System.Object.Equals(System.Object,System.Object)
        name: Equals
        nameWithType: Object.Equals
        qualifiedName: System.Object.Equals
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: System.Object
    commentId: M:System.Object.Equals(System.Object,System.Object)
  System.Object.GetHashCode:
    name:
      CSharp:
      - id: System.Object.GetHashCode
        name: GetHashCode
        nameWithType: Object.GetHashCode
        qualifiedName: System.Object.GetHashCode
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: System.Object.GetHashCode
        name: GetHashCode
        nameWithType: Object.GetHashCode
        qualifiedName: System.Object.GetHashCode
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: System.Object
    commentId: M:System.Object.GetHashCode
  System.Object.GetType:
    name:
      CSharp:
      - id: System.Object.GetType
        name: GetType
        nameWithType: Object.GetType
        qualifiedName: System.Object.GetType
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: System.Object.GetType
        name: GetType
        nameWithType: Object.GetType
        qualifiedName: System.Object.GetType
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: System.Object
    commentId: M:System.Object.GetType
  System.Object.MemberwiseClone:
    name:
      CSharp:
      - id: System.Object.MemberwiseClone
        name: MemberwiseClone
        nameWithType: Object.MemberwiseClone
        qualifiedName: System.Object.MemberwiseClone
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: System.Object.MemberwiseClone
        name: MemberwiseClone
        nameWithType: Object.MemberwiseClone
        qualifiedName: System.Object.MemberwiseClone
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: System.Object
    commentId: M:System.Object.MemberwiseClone
  System.Object.ReferenceEquals(System.Object,System.Object):
    name:
      CSharp:
      - id: System.Object.ReferenceEquals(System.Object,System.Object)
        name: ReferenceEquals
        nameWithType: Object.ReferenceEquals
        qualifiedName: System.Object.ReferenceEquals
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: System.Object.ReferenceEquals(System.Object,System.Object)
        name: ReferenceEquals
        nameWithType: Object.ReferenceEquals
        qualifiedName: System.Object.ReferenceEquals
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: System.Object
        name: Object
        nameWithType: Object
        qualifiedName: System.Object
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: System.Object
    commentId: M:System.Object.ReferenceEquals(System.Object,System.Object)
  System.Object.ToString:
    name:
      CSharp:
      - id: System.Object.ToString
        name: ToString
        nameWithType: Object.ToString
        qualifiedName: System.Object.ToString
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: System.Object.ToString
        name: ToString
        nameWithType: Object.ToString
        qualifiedName: System.Object.ToString
        isExternal: true
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: System.Object
    commentId: M:System.Object.ToString
  BLL:
    name:
      CSharp:
      - name: BLL
        nameWithType: BLL
        qualifiedName: BLL
      VB:
      - name: BLL
        nameWithType: BLL
        qualifiedName: BLL
    isDefinition: true
    commentId: N:BLL
  BLL.IAccountService:
    name:
      CSharp:
      - id: BLL.IAccountService
        name: IAccountService
        nameWithType: IAccountService
        qualifiedName: BLL.IAccountService
      VB:
      - id: BLL.IAccountService
        name: IAccountService
        nameWithType: IAccountService
        qualifiedName: BLL.IAccountService
    isDefinition: true
    parent: BLL
    commentId: T:BLL.IAccountService
  DAL.UOW:
    name:
      CSharp:
      - name: DAL.UOW
        nameWithType: DAL.UOW
        qualifiedName: DAL.UOW
      VB:
      - name: DAL.UOW
        nameWithType: DAL.UOW
        qualifiedName: DAL.UOW
    isDefinition: true
    commentId: N:DAL.UOW
  DAL.UOW.IUnitOfWork:
    name:
      CSharp:
      - id: DAL.UOW.IUnitOfWork
        name: IUnitOfWork
        nameWithType: IUnitOfWork
        qualifiedName: DAL.UOW.IUnitOfWork
      VB:
      - id: DAL.UOW.IUnitOfWork
        name: IUnitOfWork
        nameWithType: IUnitOfWork
        qualifiedName: DAL.UOW.IUnitOfWork
    isDefinition: true
    parent: DAL.UOW
    commentId: T:DAL.UOW.IUnitOfWork
  BLL.AccountService.#ctor*:
    name:
      CSharp:
      - id: BLL.AccountService.#ctor*
        name: AccountService
        nameWithType: AccountService.AccountService
        qualifiedName: BLL.AccountService.AccountService
      VB:
      - id: BLL.AccountService.#ctor*
        name: AccountService
        nameWithType: AccountService.AccountService
        qualifiedName: BLL.AccountService.AccountService
    isDefinition: true
    commentId: Overload:BLL.AccountService.#ctor
  System.Threading.Tasks.Task`1:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - name: TResult
        nameWithType: TResult
        qualifiedName: TResult
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - name: TResult
        nameWithType: TResult
        qualifiedName: TResult
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    commentId: T:System.Threading.Tasks.Task`1
  System.Threading.Tasks:
    name:
      CSharp:
      - name: System.Threading.Tasks
        nameWithType: System.Threading.Tasks
        qualifiedName: System.Threading.Tasks
        isExternal: true
      VB:
      - name: System.Threading.Tasks
        nameWithType: System.Threading.Tasks
        qualifiedName: System.Threading.Tasks
    isDefinition: true
    commentId: N:System.Threading.Tasks
  System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites._User}}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      - name: )
        nameWithType: )
        qualifiedName: )
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites._User}}
  BLL.AccountService.GetUsersAsync*:
    name:
      CSharp:
      - id: BLL.AccountService.GetUsersAsync*
        name: GetUsersAsync
        nameWithType: AccountService.GetUsersAsync
        qualifiedName: BLL.AccountService.GetUsersAsync
      VB:
      - id: BLL.AccountService.GetUsersAsync*
        name: GetUsersAsync
        nameWithType: AccountService.GetUsersAsync
        qualifiedName: BLL.AccountService.GetUsersAsync
    isDefinition: true
    commentId: Overload:BLL.AccountService.GetUsersAsync
  BLL.IAccountService.GetUsersAsync:
    name:
      CSharp:
      - id: BLL.IAccountService.GetUsersAsync
        name: GetUsersAsync
        nameWithType: IAccountService.GetUsersAsync
        qualifiedName: BLL.IAccountService.GetUsersAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IAccountService.GetUsersAsync
        name: GetUsersAsync
        nameWithType: IAccountService.GetUsersAsync
        qualifiedName: BLL.IAccountService.GetUsersAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IAccountService
    commentId: M:BLL.IAccountService.GetUsersAsync
  System.Threading.Tasks.Task{Domain.Entites._User}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{Domain.Entites._User}
  System.Int32:
    name:
      CSharp:
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      VB:
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
    isDefinition: true
    parent: System
    commentId: T:System.Int32
  BLL.AccountService.GetUserByIdAsync*:
    name:
      CSharp:
      - id: BLL.AccountService.GetUserByIdAsync*
        name: GetUserByIdAsync
        nameWithType: AccountService.GetUserByIdAsync
        qualifiedName: BLL.AccountService.GetUserByIdAsync
      VB:
      - id: BLL.AccountService.GetUserByIdAsync*
        name: GetUserByIdAsync
        nameWithType: AccountService.GetUserByIdAsync
        qualifiedName: BLL.AccountService.GetUserByIdAsync
    isDefinition: true
    commentId: Overload:BLL.AccountService.GetUserByIdAsync
  BLL.IAccountService.GetUserByIdAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IAccountService.GetUserByIdAsync(System.Int32)
        name: GetUserByIdAsync
        nameWithType: IAccountService.GetUserByIdAsync
        qualifiedName: BLL.IAccountService.GetUserByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IAccountService.GetUserByIdAsync(System.Int32)
        name: GetUserByIdAsync
        nameWithType: IAccountService.GetUserByIdAsync
        qualifiedName: BLL.IAccountService.GetUserByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IAccountService
    commentId: M:BLL.IAccountService.GetUserByIdAsync(System.Int32)
  System.String:
    name:
      CSharp:
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      VB:
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
    isDefinition: true
    parent: System
    commentId: T:System.String
  BLL.AccountService.GetUserByloginNameAsync*:
    name:
      CSharp:
      - id: BLL.AccountService.GetUserByloginNameAsync*
        name: GetUserByloginNameAsync
        nameWithType: AccountService.GetUserByloginNameAsync
        qualifiedName: BLL.AccountService.GetUserByloginNameAsync
      VB:
      - id: BLL.AccountService.GetUserByloginNameAsync*
        name: GetUserByloginNameAsync
        nameWithType: AccountService.GetUserByloginNameAsync
        qualifiedName: BLL.AccountService.GetUserByloginNameAsync
    isDefinition: true
    commentId: Overload:BLL.AccountService.GetUserByloginNameAsync
  BLL.IAccountService.GetUserByloginNameAsync(System.String):
    name:
      CSharp:
      - id: BLL.IAccountService.GetUserByloginNameAsync(System.String)
        name: GetUserByloginNameAsync
        nameWithType: IAccountService.GetUserByloginNameAsync
        qualifiedName: BLL.IAccountService.GetUserByloginNameAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IAccountService.GetUserByloginNameAsync(System.String)
        name: GetUserByloginNameAsync
        nameWithType: IAccountService.GetUserByloginNameAsync
        qualifiedName: BLL.IAccountService.GetUserByloginNameAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IAccountService
    commentId: M:BLL.IAccountService.GetUserByloginNameAsync(System.String)
  Domain.Entites:
    name:
      CSharp:
      - name: Domain.Entites
        nameWithType: Domain.Entites
        qualifiedName: Domain.Entites
      VB:
      - name: Domain.Entites
        nameWithType: Domain.Entites
        qualifiedName: Domain.Entites
    isDefinition: true
    commentId: N:Domain.Entites
  Domain.Entites._User:
    name:
      CSharp:
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      VB:
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
    isDefinition: true
    parent: Domain.Entites
    commentId: T:Domain.Entites._User
  BLL.AccountService.CreateUserAsync*:
    name:
      CSharp:
      - id: BLL.AccountService.CreateUserAsync*
        name: CreateUserAsync
        nameWithType: AccountService.CreateUserAsync
        qualifiedName: BLL.AccountService.CreateUserAsync
      VB:
      - id: BLL.AccountService.CreateUserAsync*
        name: CreateUserAsync
        nameWithType: AccountService.CreateUserAsync
        qualifiedName: BLL.AccountService.CreateUserAsync
    isDefinition: true
    commentId: Overload:BLL.AccountService.CreateUserAsync
  BLL.IAccountService.CreateUserAsync(Domain.Entites._User):
    name:
      CSharp:
      - id: BLL.IAccountService.CreateUserAsync(Domain.Entites._User)
        name: CreateUserAsync
        nameWithType: IAccountService.CreateUserAsync
        qualifiedName: BLL.IAccountService.CreateUserAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IAccountService.CreateUserAsync(Domain.Entites._User)
        name: CreateUserAsync
        nameWithType: IAccountService.CreateUserAsync
        qualifiedName: BLL.IAccountService.CreateUserAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IAccountService
    commentId: M:BLL.IAccountService.CreateUserAsync(Domain.Entites._User)
  BLL.AccountService.Encrypt*:
    name:
      CSharp:
      - id: BLL.AccountService.Encrypt*
        name: Encrypt
        nameWithType: AccountService.Encrypt
        qualifiedName: BLL.AccountService.Encrypt
      VB:
      - id: BLL.AccountService.Encrypt*
        name: Encrypt
        nameWithType: AccountService.Encrypt
        qualifiedName: BLL.AccountService.Encrypt
    isDefinition: true
    commentId: Overload:BLL.AccountService.Encrypt
  BLL.AccountService.ModifyUserAsync*:
    name:
      CSharp:
      - id: BLL.AccountService.ModifyUserAsync*
        name: ModifyUserAsync
        nameWithType: AccountService.ModifyUserAsync
        qualifiedName: BLL.AccountService.ModifyUserAsync
      VB:
      - id: BLL.AccountService.ModifyUserAsync*
        name: ModifyUserAsync
        nameWithType: AccountService.ModifyUserAsync
        qualifiedName: BLL.AccountService.ModifyUserAsync
    isDefinition: true
    commentId: Overload:BLL.AccountService.ModifyUserAsync
  BLL.IAccountService.ModifyUserAsync(Domain.Entites._User):
    name:
      CSharp:
      - id: BLL.IAccountService.ModifyUserAsync(Domain.Entites._User)
        name: ModifyUserAsync
        nameWithType: IAccountService.ModifyUserAsync
        qualifiedName: BLL.IAccountService.ModifyUserAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IAccountService.ModifyUserAsync(Domain.Entites._User)
        name: ModifyUserAsync
        nameWithType: IAccountService.ModifyUserAsync
        qualifiedName: BLL.IAccountService.ModifyUserAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites._User
        name: _User
        nameWithType: _User
        qualifiedName: Domain.Entites._User
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IAccountService
    commentId: M:BLL.IAccountService.ModifyUserAsync(Domain.Entites._User)
  System.Threading.Tasks.Task{System.Boolean}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.Boolean
        name: Boolean
        nameWithType: Boolean
        qualifiedName: System.Boolean
        isExternal: true
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.Boolean
        name: Boolean
        nameWithType: Boolean
        qualifiedName: System.Boolean
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{System.Boolean}
  BLL.AccountService.DeleteUserAsync*:
    name:
      CSharp:
      - id: BLL.AccountService.DeleteUserAsync*
        name: DeleteUserAsync
        nameWithType: AccountService.DeleteUserAsync
        qualifiedName: BLL.AccountService.DeleteUserAsync
      VB:
      - id: BLL.AccountService.DeleteUserAsync*
        name: DeleteUserAsync
        nameWithType: AccountService.DeleteUserAsync
        qualifiedName: BLL.AccountService.DeleteUserAsync
    isDefinition: true
    commentId: Overload:BLL.AccountService.DeleteUserAsync
  BLL.IAccountService.DeleteUserAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IAccountService.DeleteUserAsync(System.Int32)
        name: DeleteUserAsync
        nameWithType: IAccountService.DeleteUserAsync
        qualifiedName: BLL.IAccountService.DeleteUserAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IAccountService.DeleteUserAsync(System.Int32)
        name: DeleteUserAsync
        nameWithType: IAccountService.DeleteUserAsync
        qualifiedName: BLL.IAccountService.DeleteUserAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IAccountService
    commentId: M:BLL.IAccountService.DeleteUserAsync(System.Int32)
  BLL.AccountService.Encryp*:
    name:
      CSharp:
      - id: BLL.AccountService.Encryp*
        name: Encryp
        nameWithType: AccountService.Encryp
        qualifiedName: BLL.AccountService.Encryp
      VB:
      - id: BLL.AccountService.Encryp*
        name: Encryp
        nameWithType: AccountService.Encryp
        qualifiedName: BLL.AccountService.Encryp
    isDefinition: true
    commentId: Overload:BLL.AccountService.Encryp
  BLL.AccountService.Decrypt*:
    name:
      CSharp:
      - id: BLL.AccountService.Decrypt*
        name: Decrypt
        nameWithType: AccountService.Decrypt
        qualifiedName: BLL.AccountService.Decrypt
      VB:
      - id: BLL.AccountService.Decrypt*
        name: Decrypt
        nameWithType: AccountService.Decrypt
        qualifiedName: BLL.AccountService.Decrypt
    isDefinition: true
    commentId: Overload:BLL.AccountService.Decrypt
  BLL.AccountService:
    name:
      CSharp:
      - id: BLL.AccountService
        name: AccountService
        nameWithType: AccountService
        qualifiedName: BLL.AccountService
      VB:
      - id: BLL.AccountService
        name: AccountService
        nameWithType: AccountService
        qualifiedName: BLL.AccountService
    isDefinition: true
    commentId: T:BLL.AccountService
  Microsoft.Extensions.DependencyInjection:
    name:
      CSharp:
      - name: Microsoft.Extensions.DependencyInjection
        nameWithType: Microsoft.Extensions.DependencyInjection
        qualifiedName: Microsoft.Extensions.DependencyInjection
        isExternal: true
      VB:
      - name: Microsoft.Extensions.DependencyInjection
        nameWithType: Microsoft.Extensions.DependencyInjection
        qualifiedName: Microsoft.Extensions.DependencyInjection
    isDefinition: true
    commentId: N:Microsoft.Extensions.DependencyInjection
  Microsoft.Extensions.DependencyInjection.IServiceCollection:
    name:
      CSharp:
      - id: Microsoft.Extensions.DependencyInjection.IServiceCollection
        name: IServiceCollection
        nameWithType: IServiceCollection
        qualifiedName: Microsoft.Extensions.DependencyInjection.IServiceCollection
        isExternal: true
      VB:
      - id: Microsoft.Extensions.DependencyInjection.IServiceCollection
        name: IServiceCollection
        nameWithType: IServiceCollection
        qualifiedName: Microsoft.Extensions.DependencyInjection.IServiceCollection
        isExternal: true
    isDefinition: true
    parent: Microsoft.Extensions.DependencyInjection
    commentId: T:Microsoft.Extensions.DependencyInjection.IServiceCollection
  BLL.BLLExtensions.AddBLLExtension*:
    name:
      CSharp:
      - id: BLL.BLLExtensions.AddBLLExtension*
        name: AddBLLExtension
        nameWithType: BLLExtensions.AddBLLExtension
        qualifiedName: BLL.BLLExtensions.AddBLLExtension
      VB:
      - id: BLL.BLLExtensions.AddBLLExtension*
        name: AddBLLExtension
        nameWithType: BLLExtensions.AddBLLExtension
        qualifiedName: BLL.BLLExtensions.AddBLLExtension
    isDefinition: true
    commentId: Overload:BLL.BLLExtensions.AddBLLExtension
  BLL.BLLExtensions:
    name:
      CSharp:
      - id: BLL.BLLExtensions
        name: BLLExtensions
        nameWithType: BLLExtensions
        qualifiedName: BLL.BLLExtensions
      VB:
      - id: BLL.BLLExtensions
        name: BLLExtensions
        nameWithType: BLLExtensions
        qualifiedName: BLL.BLLExtensions
    isDefinition: true
    commentId: T:BLL.BLLExtensions
  BLL.IForumService:
    name:
      CSharp:
      - id: BLL.IForumService
        name: IForumService
        nameWithType: IForumService
        qualifiedName: BLL.IForumService
      VB:
      - id: BLL.IForumService
        name: IForumService
        nameWithType: IForumService
        qualifiedName: BLL.IForumService
    isDefinition: true
    parent: BLL
    commentId: T:BLL.IForumService
  BLL.ForumService.#ctor*:
    name:
      CSharp:
      - id: BLL.ForumService.#ctor*
        name: ForumService
        nameWithType: ForumService.ForumService
        qualifiedName: BLL.ForumService.ForumService
      VB:
      - id: BLL.ForumService.#ctor*
        name: ForumService
        nameWithType: ForumService.ForumService
        qualifiedName: BLL.ForumService.ForumService
    isDefinition: true
    commentId: Overload:BLL.ForumService.#ctor
  System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Rubric}}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      - name: )
        nameWithType: )
        qualifiedName: )
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Rubric}}
  BLL.ForumService.GetRubricsAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.GetRubricsAsync*
        name: GetRubricsAsync
        nameWithType: ForumService.GetRubricsAsync
        qualifiedName: BLL.ForumService.GetRubricsAsync
      VB:
      - id: BLL.ForumService.GetRubricsAsync*
        name: GetRubricsAsync
        nameWithType: ForumService.GetRubricsAsync
        qualifiedName: BLL.ForumService.GetRubricsAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.GetRubricsAsync
  BLL.IForumService.GetRubricsAsync:
    name:
      CSharp:
      - id: BLL.IForumService.GetRubricsAsync
        name: GetRubricsAsync
        nameWithType: IForumService.GetRubricsAsync
        qualifiedName: BLL.IForumService.GetRubricsAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.GetRubricsAsync
        name: GetRubricsAsync
        nameWithType: IForumService.GetRubricsAsync
        qualifiedName: BLL.IForumService.GetRubricsAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.GetRubricsAsync
  System.Threading.Tasks.Task{Domain.Entites.Rubric}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{Domain.Entites.Rubric}
  BLL.ForumService.GetRubricByIdAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.GetRubricByIdAsync*
        name: GetRubricByIdAsync
        nameWithType: ForumService.GetRubricByIdAsync
        qualifiedName: BLL.ForumService.GetRubricByIdAsync
      VB:
      - id: BLL.ForumService.GetRubricByIdAsync*
        name: GetRubricByIdAsync
        nameWithType: ForumService.GetRubricByIdAsync
        qualifiedName: BLL.ForumService.GetRubricByIdAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.GetRubricByIdAsync
  BLL.IForumService.GetRubricByIdAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.GetRubricByIdAsync(System.Int32)
        name: GetRubricByIdAsync
        nameWithType: IForumService.GetRubricByIdAsync
        qualifiedName: BLL.IForumService.GetRubricByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.GetRubricByIdAsync(System.Int32)
        name: GetRubricByIdAsync
        nameWithType: IForumService.GetRubricByIdAsync
        qualifiedName: BLL.IForumService.GetRubricByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.GetRubricByIdAsync(System.Int32)
  Domain.Entites.Rubric:
    name:
      CSharp:
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      VB:
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
    isDefinition: true
    parent: Domain.Entites
    commentId: T:Domain.Entites.Rubric
  BLL.ForumService.CreateRubricAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.CreateRubricAsync*
        name: CreateRubricAsync
        nameWithType: ForumService.CreateRubricAsync
        qualifiedName: BLL.ForumService.CreateRubricAsync
      VB:
      - id: BLL.ForumService.CreateRubricAsync*
        name: CreateRubricAsync
        nameWithType: ForumService.CreateRubricAsync
        qualifiedName: BLL.ForumService.CreateRubricAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.CreateRubricAsync
  BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric):
    name:
      CSharp:
      - id: BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric)
        name: CreateRubricAsync
        nameWithType: IForumService.CreateRubricAsync
        qualifiedName: BLL.IForumService.CreateRubricAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric)
        name: CreateRubricAsync
        nameWithType: IForumService.CreateRubricAsync
        qualifiedName: BLL.IForumService.CreateRubricAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.CreateRubricAsync(Domain.Entites.Rubric)
  BLL.ForumService.ModifyRubricAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.ModifyRubricAsync*
        name: ModifyRubricAsync
        nameWithType: ForumService.ModifyRubricAsync
        qualifiedName: BLL.ForumService.ModifyRubricAsync
      VB:
      - id: BLL.ForumService.ModifyRubricAsync*
        name: ModifyRubricAsync
        nameWithType: ForumService.ModifyRubricAsync
        qualifiedName: BLL.ForumService.ModifyRubricAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.ModifyRubricAsync
  BLL.IForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric):
    name:
      CSharp:
      - id: BLL.IForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric)
        name: ModifyRubricAsync
        nameWithType: IForumService.ModifyRubricAsync
        qualifiedName: BLL.IForumService.ModifyRubricAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric)
        name: ModifyRubricAsync
        nameWithType: IForumService.ModifyRubricAsync
        qualifiedName: BLL.IForumService.ModifyRubricAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: Domain.Entites.Rubric
        name: Rubric
        nameWithType: Rubric
        qualifiedName: Domain.Entites.Rubric
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.ModifyRubricAsync(System.Int32,Domain.Entites.Rubric)
  BLL.ForumService.DeleteRubricAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.DeleteRubricAsync*
        name: DeleteRubricAsync
        nameWithType: ForumService.DeleteRubricAsync
        qualifiedName: BLL.ForumService.DeleteRubricAsync
      VB:
      - id: BLL.ForumService.DeleteRubricAsync*
        name: DeleteRubricAsync
        nameWithType: ForumService.DeleteRubricAsync
        qualifiedName: BLL.ForumService.DeleteRubricAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.DeleteRubricAsync
  BLL.IForumService.DeleteRubricAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.DeleteRubricAsync(System.Int32)
        name: DeleteRubricAsync
        nameWithType: IForumService.DeleteRubricAsync
        qualifiedName: BLL.IForumService.DeleteRubricAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.DeleteRubricAsync(System.Int32)
        name: DeleteRubricAsync
        nameWithType: IForumService.DeleteRubricAsync
        qualifiedName: BLL.IForumService.DeleteRubricAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.DeleteRubricAsync(System.Int32)
  System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.RubricDetail}}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites.RubricDetail
        name: RubricDetail
        nameWithType: RubricDetail
        qualifiedName: Domain.Entites.RubricDetail
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites.RubricDetail
        name: RubricDetail
        nameWithType: RubricDetail
        qualifiedName: Domain.Entites.RubricDetail
      - name: )
        nameWithType: )
        qualifiedName: )
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.RubricDetail}}
  BLL.ForumService.DetailRubricsAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.DetailRubricsAsync*
        name: DetailRubricsAsync
        nameWithType: ForumService.DetailRubricsAsync
        qualifiedName: BLL.ForumService.DetailRubricsAsync
      VB:
      - id: BLL.ForumService.DetailRubricsAsync*
        name: DetailRubricsAsync
        nameWithType: ForumService.DetailRubricsAsync
        qualifiedName: BLL.ForumService.DetailRubricsAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.DetailRubricsAsync
  BLL.IForumService.DetailRubricsAsync:
    name:
      CSharp:
      - id: BLL.IForumService.DetailRubricsAsync
        name: DetailRubricsAsync
        nameWithType: IForumService.DetailRubricsAsync
        qualifiedName: BLL.IForumService.DetailRubricsAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.DetailRubricsAsync
        name: DetailRubricsAsync
        nameWithType: IForumService.DetailRubricsAsync
        qualifiedName: BLL.IForumService.DetailRubricsAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.DetailRubricsAsync
  BLL.ForumService.DetailRubricByIdAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.DetailRubricByIdAsync*
        name: DetailRubricByIdAsync
        nameWithType: ForumService.DetailRubricByIdAsync
        qualifiedName: BLL.ForumService.DetailRubricByIdAsync
      VB:
      - id: BLL.ForumService.DetailRubricByIdAsync*
        name: DetailRubricByIdAsync
        nameWithType: ForumService.DetailRubricByIdAsync
        qualifiedName: BLL.ForumService.DetailRubricByIdAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.DetailRubricByIdAsync
  BLL.IForumService.DetailRubricByIdAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.DetailRubricByIdAsync(System.Int32)
        name: DetailRubricByIdAsync
        nameWithType: IForumService.DetailRubricByIdAsync
        qualifiedName: BLL.IForumService.DetailRubricByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.DetailRubricByIdAsync(System.Int32)
        name: DetailRubricByIdAsync
        nameWithType: IForumService.DetailRubricByIdAsync
        qualifiedName: BLL.IForumService.DetailRubricByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.DetailRubricByIdAsync(System.Int32)
  System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Topic}}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      - name: )
        nameWithType: )
        qualifiedName: )
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Topic}}
  BLL.ForumService.GetTopicsAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.GetTopicsAsync*
        name: GetTopicsAsync
        nameWithType: ForumService.GetTopicsAsync
        qualifiedName: BLL.ForumService.GetTopicsAsync
      VB:
      - id: BLL.ForumService.GetTopicsAsync*
        name: GetTopicsAsync
        nameWithType: ForumService.GetTopicsAsync
        qualifiedName: BLL.ForumService.GetTopicsAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.GetTopicsAsync
  BLL.IForumService.GetTopicsAsync:
    name:
      CSharp:
      - id: BLL.IForumService.GetTopicsAsync
        name: GetTopicsAsync
        nameWithType: IForumService.GetTopicsAsync
        qualifiedName: BLL.IForumService.GetTopicsAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.GetTopicsAsync
        name: GetTopicsAsync
        nameWithType: IForumService.GetTopicsAsync
        qualifiedName: BLL.IForumService.GetTopicsAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.GetTopicsAsync
  BLL.ForumService.GetTopicsByRubricIdAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.GetTopicsByRubricIdAsync*
        name: GetTopicsByRubricIdAsync
        nameWithType: ForumService.GetTopicsByRubricIdAsync
        qualifiedName: BLL.ForumService.GetTopicsByRubricIdAsync
      VB:
      - id: BLL.ForumService.GetTopicsByRubricIdAsync*
        name: GetTopicsByRubricIdAsync
        nameWithType: ForumService.GetTopicsByRubricIdAsync
        qualifiedName: BLL.ForumService.GetTopicsByRubricIdAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.GetTopicsByRubricIdAsync
  BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32)
        name: GetTopicsByRubricIdAsync
        nameWithType: IForumService.GetTopicsByRubricIdAsync
        qualifiedName: BLL.IForumService.GetTopicsByRubricIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32)
        name: GetTopicsByRubricIdAsync
        nameWithType: IForumService.GetTopicsByRubricIdAsync
        qualifiedName: BLL.IForumService.GetTopicsByRubricIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.GetTopicsByRubricIdAsync(System.Int32)
  System.Threading.Tasks.Task{Domain.Entites.Topic}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{Domain.Entites.Topic}
  BLL.ForumService.GetTopicByIdAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.GetTopicByIdAsync*
        name: GetTopicByIdAsync
        nameWithType: ForumService.GetTopicByIdAsync
        qualifiedName: BLL.ForumService.GetTopicByIdAsync
      VB:
      - id: BLL.ForumService.GetTopicByIdAsync*
        name: GetTopicByIdAsync
        nameWithType: ForumService.GetTopicByIdAsync
        qualifiedName: BLL.ForumService.GetTopicByIdAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.GetTopicByIdAsync
  BLL.IForumService.GetTopicByIdAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.GetTopicByIdAsync(System.Int32)
        name: GetTopicByIdAsync
        nameWithType: IForumService.GetTopicByIdAsync
        qualifiedName: BLL.IForumService.GetTopicByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.GetTopicByIdAsync(System.Int32)
        name: GetTopicByIdAsync
        nameWithType: IForumService.GetTopicByIdAsync
        qualifiedName: BLL.IForumService.GetTopicByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.GetTopicByIdAsync(System.Int32)
  Domain.Entites.Topic:
    name:
      CSharp:
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      VB:
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
    isDefinition: true
    parent: Domain.Entites
    commentId: T:Domain.Entites.Topic
  BLL.ForumService.CreateTopicAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.CreateTopicAsync*
        name: CreateTopicAsync
        nameWithType: ForumService.CreateTopicAsync
        qualifiedName: BLL.ForumService.CreateTopicAsync
      VB:
      - id: BLL.ForumService.CreateTopicAsync*
        name: CreateTopicAsync
        nameWithType: ForumService.CreateTopicAsync
        qualifiedName: BLL.ForumService.CreateTopicAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.CreateTopicAsync
  BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic):
    name:
      CSharp:
      - id: BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic)
        name: CreateTopicAsync
        nameWithType: IForumService.CreateTopicAsync
        qualifiedName: BLL.IForumService.CreateTopicAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic)
        name: CreateTopicAsync
        nameWithType: IForumService.CreateTopicAsync
        qualifiedName: BLL.IForumService.CreateTopicAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.CreateTopicAsync(Domain.Entites.Topic)
  BLL.ForumService.ModifyTopicAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.ModifyTopicAsync*
        name: ModifyTopicAsync
        nameWithType: ForumService.ModifyTopicAsync
        qualifiedName: BLL.ForumService.ModifyTopicAsync
      VB:
      - id: BLL.ForumService.ModifyTopicAsync*
        name: ModifyTopicAsync
        nameWithType: ForumService.ModifyTopicAsync
        qualifiedName: BLL.ForumService.ModifyTopicAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.ModifyTopicAsync
  BLL.IForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic):
    name:
      CSharp:
      - id: BLL.IForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic)
        name: ModifyTopicAsync
        nameWithType: IForumService.ModifyTopicAsync
        qualifiedName: BLL.IForumService.ModifyTopicAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic)
        name: ModifyTopicAsync
        nameWithType: IForumService.ModifyTopicAsync
        qualifiedName: BLL.IForumService.ModifyTopicAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: Domain.Entites.Topic
        name: Topic
        nameWithType: Topic
        qualifiedName: Domain.Entites.Topic
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.ModifyTopicAsync(System.Int32,Domain.Entites.Topic)
  BLL.ForumService.DeleteTopicAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.DeleteTopicAsync*
        name: DeleteTopicAsync
        nameWithType: ForumService.DeleteTopicAsync
        qualifiedName: BLL.ForumService.DeleteTopicAsync
      VB:
      - id: BLL.ForumService.DeleteTopicAsync*
        name: DeleteTopicAsync
        nameWithType: ForumService.DeleteTopicAsync
        qualifiedName: BLL.ForumService.DeleteTopicAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.DeleteTopicAsync
  BLL.IForumService.DeleteTopicAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.DeleteTopicAsync(System.Int32)
        name: DeleteTopicAsync
        nameWithType: IForumService.DeleteTopicAsync
        qualifiedName: BLL.IForumService.DeleteTopicAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.DeleteTopicAsync(System.Int32)
        name: DeleteTopicAsync
        nameWithType: IForumService.DeleteTopicAsync
        qualifiedName: BLL.IForumService.DeleteTopicAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.DeleteTopicAsync(System.Int32)
  System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.TopicDetail}}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites.TopicDetail
        name: TopicDetail
        nameWithType: TopicDetail
        qualifiedName: Domain.Entites.TopicDetail
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites.TopicDetail
        name: TopicDetail
        nameWithType: TopicDetail
        qualifiedName: Domain.Entites.TopicDetail
      - name: )
        nameWithType: )
        qualifiedName: )
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.TopicDetail}}
  BLL.ForumService.DetailTopicsAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.DetailTopicsAsync*
        name: DetailTopicsAsync
        nameWithType: ForumService.DetailTopicsAsync
        qualifiedName: BLL.ForumService.DetailTopicsAsync
      VB:
      - id: BLL.ForumService.DetailTopicsAsync*
        name: DetailTopicsAsync
        nameWithType: ForumService.DetailTopicsAsync
        qualifiedName: BLL.ForumService.DetailTopicsAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.DetailTopicsAsync
  BLL.IForumService.DetailTopicsAsync:
    name:
      CSharp:
      - id: BLL.IForumService.DetailTopicsAsync
        name: DetailTopicsAsync
        nameWithType: IForumService.DetailTopicsAsync
        qualifiedName: BLL.IForumService.DetailTopicsAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.DetailTopicsAsync
        name: DetailTopicsAsync
        nameWithType: IForumService.DetailTopicsAsync
        qualifiedName: BLL.IForumService.DetailTopicsAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.DetailTopicsAsync
  BLL.ForumService.DetailTopicByIdAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.DetailTopicByIdAsync*
        name: DetailTopicByIdAsync
        nameWithType: ForumService.DetailTopicByIdAsync
        qualifiedName: BLL.ForumService.DetailTopicByIdAsync
      VB:
      - id: BLL.ForumService.DetailTopicByIdAsync*
        name: DetailTopicByIdAsync
        nameWithType: ForumService.DetailTopicByIdAsync
        qualifiedName: BLL.ForumService.DetailTopicByIdAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.DetailTopicByIdAsync
  BLL.IForumService.DetailTopicByIdAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.DetailTopicByIdAsync(System.Int32)
        name: DetailTopicByIdAsync
        nameWithType: IForumService.DetailTopicByIdAsync
        qualifiedName: BLL.IForumService.DetailTopicByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.DetailTopicByIdAsync(System.Int32)
        name: DetailTopicByIdAsync
        nameWithType: IForumService.DetailTopicByIdAsync
        qualifiedName: BLL.IForumService.DetailTopicByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.DetailTopicByIdAsync(System.Int32)
  System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Reply}}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.Collections.Generic.IEnumerable`1
        name: IEnumerable
        nameWithType: IEnumerable
        qualifiedName: System.Collections.Generic.IEnumerable
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      - name: )
        nameWithType: )
        qualifiedName: )
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{Domain.Entites.Reply}}
  BLL.ForumService.GetRepliesAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.GetRepliesAsync*
        name: GetRepliesAsync
        nameWithType: ForumService.GetRepliesAsync
        qualifiedName: BLL.ForumService.GetRepliesAsync
      VB:
      - id: BLL.ForumService.GetRepliesAsync*
        name: GetRepliesAsync
        nameWithType: ForumService.GetRepliesAsync
        qualifiedName: BLL.ForumService.GetRepliesAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.GetRepliesAsync
  BLL.IForumService.GetRepliesAsync:
    name:
      CSharp:
      - id: BLL.IForumService.GetRepliesAsync
        name: GetRepliesAsync
        nameWithType: IForumService.GetRepliesAsync
        qualifiedName: BLL.IForumService.GetRepliesAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.GetRepliesAsync
        name: GetRepliesAsync
        nameWithType: IForumService.GetRepliesAsync
        qualifiedName: BLL.IForumService.GetRepliesAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.GetRepliesAsync
  BLL.ForumService.GetRepliesByTopicIdAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.GetRepliesByTopicIdAsync*
        name: GetRepliesByTopicIdAsync
        nameWithType: ForumService.GetRepliesByTopicIdAsync
        qualifiedName: BLL.ForumService.GetRepliesByTopicIdAsync
      VB:
      - id: BLL.ForumService.GetRepliesByTopicIdAsync*
        name: GetRepliesByTopicIdAsync
        nameWithType: ForumService.GetRepliesByTopicIdAsync
        qualifiedName: BLL.ForumService.GetRepliesByTopicIdAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.GetRepliesByTopicIdAsync
  BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32)
        name: GetRepliesByTopicIdAsync
        nameWithType: IForumService.GetRepliesByTopicIdAsync
        qualifiedName: BLL.IForumService.GetRepliesByTopicIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32)
        name: GetRepliesByTopicIdAsync
        nameWithType: IForumService.GetRepliesByTopicIdAsync
        qualifiedName: BLL.IForumService.GetRepliesByTopicIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.GetRepliesByTopicIdAsync(System.Int32)
  System.Threading.Tasks.Task{Domain.Entites.Reply}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{Domain.Entites.Reply}
  BLL.ForumService.GetReplyByIdAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.GetReplyByIdAsync*
        name: GetReplyByIdAsync
        nameWithType: ForumService.GetReplyByIdAsync
        qualifiedName: BLL.ForumService.GetReplyByIdAsync
      VB:
      - id: BLL.ForumService.GetReplyByIdAsync*
        name: GetReplyByIdAsync
        nameWithType: ForumService.GetReplyByIdAsync
        qualifiedName: BLL.ForumService.GetReplyByIdAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.GetReplyByIdAsync
  BLL.IForumService.GetReplyByIdAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.GetReplyByIdAsync(System.Int32)
        name: GetReplyByIdAsync
        nameWithType: IForumService.GetReplyByIdAsync
        qualifiedName: BLL.IForumService.GetReplyByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.GetReplyByIdAsync(System.Int32)
        name: GetReplyByIdAsync
        nameWithType: IForumService.GetReplyByIdAsync
        qualifiedName: BLL.IForumService.GetReplyByIdAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.GetReplyByIdAsync(System.Int32)
  Domain.Entites.Reply:
    name:
      CSharp:
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      VB:
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
    isDefinition: true
    parent: Domain.Entites
    commentId: T:Domain.Entites.Reply
  BLL.ForumService.CreateReplyAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.CreateReplyAsync*
        name: CreateReplyAsync
        nameWithType: ForumService.CreateReplyAsync
        qualifiedName: BLL.ForumService.CreateReplyAsync
      VB:
      - id: BLL.ForumService.CreateReplyAsync*
        name: CreateReplyAsync
        nameWithType: ForumService.CreateReplyAsync
        qualifiedName: BLL.ForumService.CreateReplyAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.CreateReplyAsync
  BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply):
    name:
      CSharp:
      - id: BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply)
        name: CreateReplyAsync
        nameWithType: IForumService.CreateReplyAsync
        qualifiedName: BLL.IForumService.CreateReplyAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply)
        name: CreateReplyAsync
        nameWithType: IForumService.CreateReplyAsync
        qualifiedName: BLL.IForumService.CreateReplyAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.CreateReplyAsync(Domain.Entites.Reply)
  BLL.ForumService.ModifyReplyAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.ModifyReplyAsync*
        name: ModifyReplyAsync
        nameWithType: ForumService.ModifyReplyAsync
        qualifiedName: BLL.ForumService.ModifyReplyAsync
      VB:
      - id: BLL.ForumService.ModifyReplyAsync*
        name: ModifyReplyAsync
        nameWithType: ForumService.ModifyReplyAsync
        qualifiedName: BLL.ForumService.ModifyReplyAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.ModifyReplyAsync
  BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply):
    name:
      CSharp:
      - id: BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply)
        name: ModifyReplyAsync
        nameWithType: IForumService.ModifyReplyAsync
        qualifiedName: BLL.IForumService.ModifyReplyAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply)
        name: ModifyReplyAsync
        nameWithType: IForumService.ModifyReplyAsync
        qualifiedName: BLL.IForumService.ModifyReplyAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: Domain.Entites.Reply
        name: Reply
        nameWithType: Reply
        qualifiedName: Domain.Entites.Reply
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.ModifyReplyAsync(Domain.Entites.Reply)
  BLL.ForumService.DeleteReplyAsync*:
    name:
      CSharp:
      - id: BLL.ForumService.DeleteReplyAsync*
        name: DeleteReplyAsync
        nameWithType: ForumService.DeleteReplyAsync
        qualifiedName: BLL.ForumService.DeleteReplyAsync
      VB:
      - id: BLL.ForumService.DeleteReplyAsync*
        name: DeleteReplyAsync
        nameWithType: ForumService.DeleteReplyAsync
        qualifiedName: BLL.ForumService.DeleteReplyAsync
    isDefinition: true
    commentId: Overload:BLL.ForumService.DeleteReplyAsync
  BLL.IForumService.DeleteReplyAsync(System.Int32):
    name:
      CSharp:
      - id: BLL.IForumService.DeleteReplyAsync(System.Int32)
        name: DeleteReplyAsync
        nameWithType: IForumService.DeleteReplyAsync
        qualifiedName: BLL.IForumService.DeleteReplyAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.IForumService.DeleteReplyAsync(System.Int32)
        name: DeleteReplyAsync
        nameWithType: IForumService.DeleteReplyAsync
        qualifiedName: BLL.IForumService.DeleteReplyAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.Int32
        name: Int32
        nameWithType: Int32
        qualifiedName: System.Int32
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.IForumService
    commentId: M:BLL.IForumService.DeleteReplyAsync(System.Int32)
  BLL.ForumService:
    name:
      CSharp:
      - id: BLL.ForumService
        name: ForumService
        nameWithType: ForumService
        qualifiedName: BLL.ForumService
      VB:
      - id: BLL.ForumService
        name: ForumService
        nameWithType: ForumService
        qualifiedName: BLL.ForumService
    isDefinition: true
    commentId: T:BLL.ForumService
  BLL.IAccountService.CreateUserAsync*:
    name:
      CSharp:
      - id: BLL.IAccountService.CreateUserAsync*
        name: CreateUserAsync
        nameWithType: IAccountService.CreateUserAsync
        qualifiedName: BLL.IAccountService.CreateUserAsync
      VB:
      - id: BLL.IAccountService.CreateUserAsync*
        name: CreateUserAsync
        nameWithType: IAccountService.CreateUserAsync
        qualifiedName: BLL.IAccountService.CreateUserAsync
    isDefinition: true
    commentId: Overload:BLL.IAccountService.CreateUserAsync
  BLL.IAccountService.DeleteUserAsync*:
    name:
      CSharp:
      - id: BLL.IAccountService.DeleteUserAsync*
        name: DeleteUserAsync
        nameWithType: IAccountService.DeleteUserAsync
        qualifiedName: BLL.IAccountService.DeleteUserAsync
      VB:
      - id: BLL.IAccountService.DeleteUserAsync*
        name: DeleteUserAsync
        nameWithType: IAccountService.DeleteUserAsync
        qualifiedName: BLL.IAccountService.DeleteUserAsync
    isDefinition: true
    commentId: Overload:BLL.IAccountService.DeleteUserAsync
  BLL.IAccountService.GetUserByIdAsync*:
    name:
      CSharp:
      - id: BLL.IAccountService.GetUserByIdAsync*
        name: GetUserByIdAsync
        nameWithType: IAccountService.GetUserByIdAsync
        qualifiedName: BLL.IAccountService.GetUserByIdAsync
      VB:
      - id: BLL.IAccountService.GetUserByIdAsync*
        name: GetUserByIdAsync
        nameWithType: IAccountService.GetUserByIdAsync
        qualifiedName: BLL.IAccountService.GetUserByIdAsync
    isDefinition: true
    commentId: Overload:BLL.IAccountService.GetUserByIdAsync
  BLL.IAccountService.GetUsersAsync*:
    name:
      CSharp:
      - id: BLL.IAccountService.GetUsersAsync*
        name: GetUsersAsync
        nameWithType: IAccountService.GetUsersAsync
        qualifiedName: BLL.IAccountService.GetUsersAsync
      VB:
      - id: BLL.IAccountService.GetUsersAsync*
        name: GetUsersAsync
        nameWithType: IAccountService.GetUsersAsync
        qualifiedName: BLL.IAccountService.GetUsersAsync
    isDefinition: true
    commentId: Overload:BLL.IAccountService.GetUsersAsync
  BLL.IAccountService.GetUserByloginNameAsync*:
    name:
      CSharp:
      - id: BLL.IAccountService.GetUserByloginNameAsync*
        name: GetUserByloginNameAsync
        nameWithType: IAccountService.GetUserByloginNameAsync
        qualifiedName: BLL.IAccountService.GetUserByloginNameAsync
      VB:
      - id: BLL.IAccountService.GetUserByloginNameAsync*
        name: GetUserByloginNameAsync
        nameWithType: IAccountService.GetUserByloginNameAsync
        qualifiedName: BLL.IAccountService.GetUserByloginNameAsync
    isDefinition: true
    commentId: Overload:BLL.IAccountService.GetUserByloginNameAsync
  BLL.IAccountService.ModifyUserAsync*:
    name:
      CSharp:
      - id: BLL.IAccountService.ModifyUserAsync*
        name: ModifyUserAsync
        nameWithType: IAccountService.ModifyUserAsync
        qualifiedName: BLL.IAccountService.ModifyUserAsync
      VB:
      - id: BLL.IAccountService.ModifyUserAsync*
        name: ModifyUserAsync
        nameWithType: IAccountService.ModifyUserAsync
        qualifiedName: BLL.IAccountService.ModifyUserAsync
    isDefinition: true
    commentId: Overload:BLL.IAccountService.ModifyUserAsync
  BLL.IForumService.CreateReplyAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.CreateReplyAsync*
        name: CreateReplyAsync
        nameWithType: IForumService.CreateReplyAsync
        qualifiedName: BLL.IForumService.CreateReplyAsync
      VB:
      - id: BLL.IForumService.CreateReplyAsync*
        name: CreateReplyAsync
        nameWithType: IForumService.CreateReplyAsync
        qualifiedName: BLL.IForumService.CreateReplyAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.CreateReplyAsync
  BLL.IForumService.CreateRubricAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.CreateRubricAsync*
        name: CreateRubricAsync
        nameWithType: IForumService.CreateRubricAsync
        qualifiedName: BLL.IForumService.CreateRubricAsync
      VB:
      - id: BLL.IForumService.CreateRubricAsync*
        name: CreateRubricAsync
        nameWithType: IForumService.CreateRubricAsync
        qualifiedName: BLL.IForumService.CreateRubricAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.CreateRubricAsync
  BLL.IForumService.CreateTopicAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.CreateTopicAsync*
        name: CreateTopicAsync
        nameWithType: IForumService.CreateTopicAsync
        qualifiedName: BLL.IForumService.CreateTopicAsync
      VB:
      - id: BLL.IForumService.CreateTopicAsync*
        name: CreateTopicAsync
        nameWithType: IForumService.CreateTopicAsync
        qualifiedName: BLL.IForumService.CreateTopicAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.CreateTopicAsync
  BLL.IForumService.DeleteReplyAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.DeleteReplyAsync*
        name: DeleteReplyAsync
        nameWithType: IForumService.DeleteReplyAsync
        qualifiedName: BLL.IForumService.DeleteReplyAsync
      VB:
      - id: BLL.IForumService.DeleteReplyAsync*
        name: DeleteReplyAsync
        nameWithType: IForumService.DeleteReplyAsync
        qualifiedName: BLL.IForumService.DeleteReplyAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.DeleteReplyAsync
  BLL.IForumService.DeleteRubricAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.DeleteRubricAsync*
        name: DeleteRubricAsync
        nameWithType: IForumService.DeleteRubricAsync
        qualifiedName: BLL.IForumService.DeleteRubricAsync
      VB:
      - id: BLL.IForumService.DeleteRubricAsync*
        name: DeleteRubricAsync
        nameWithType: IForumService.DeleteRubricAsync
        qualifiedName: BLL.IForumService.DeleteRubricAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.DeleteRubricAsync
  BLL.IForumService.DeleteTopicAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.DeleteTopicAsync*
        name: DeleteTopicAsync
        nameWithType: IForumService.DeleteTopicAsync
        qualifiedName: BLL.IForumService.DeleteTopicAsync
      VB:
      - id: BLL.IForumService.DeleteTopicAsync*
        name: DeleteTopicAsync
        nameWithType: IForumService.DeleteTopicAsync
        qualifiedName: BLL.IForumService.DeleteTopicAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.DeleteTopicAsync
  BLL.IForumService.GetRepliesAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.GetRepliesAsync*
        name: GetRepliesAsync
        nameWithType: IForumService.GetRepliesAsync
        qualifiedName: BLL.IForumService.GetRepliesAsync
      VB:
      - id: BLL.IForumService.GetRepliesAsync*
        name: GetRepliesAsync
        nameWithType: IForumService.GetRepliesAsync
        qualifiedName: BLL.IForumService.GetRepliesAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.GetRepliesAsync
  BLL.IForumService.GetRepliesByTopicIdAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.GetRepliesByTopicIdAsync*
        name: GetRepliesByTopicIdAsync
        nameWithType: IForumService.GetRepliesByTopicIdAsync
        qualifiedName: BLL.IForumService.GetRepliesByTopicIdAsync
      VB:
      - id: BLL.IForumService.GetRepliesByTopicIdAsync*
        name: GetRepliesByTopicIdAsync
        nameWithType: IForumService.GetRepliesByTopicIdAsync
        qualifiedName: BLL.IForumService.GetRepliesByTopicIdAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.GetRepliesByTopicIdAsync
  BLL.IForumService.GetReplyByIdAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.GetReplyByIdAsync*
        name: GetReplyByIdAsync
        nameWithType: IForumService.GetReplyByIdAsync
        qualifiedName: BLL.IForumService.GetReplyByIdAsync
      VB:
      - id: BLL.IForumService.GetReplyByIdAsync*
        name: GetReplyByIdAsync
        nameWithType: IForumService.GetReplyByIdAsync
        qualifiedName: BLL.IForumService.GetReplyByIdAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.GetReplyByIdAsync
  BLL.IForumService.GetRubricByIdAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.GetRubricByIdAsync*
        name: GetRubricByIdAsync
        nameWithType: IForumService.GetRubricByIdAsync
        qualifiedName: BLL.IForumService.GetRubricByIdAsync
      VB:
      - id: BLL.IForumService.GetRubricByIdAsync*
        name: GetRubricByIdAsync
        nameWithType: IForumService.GetRubricByIdAsync
        qualifiedName: BLL.IForumService.GetRubricByIdAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.GetRubricByIdAsync
  BLL.IForumService.GetRubricsAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.GetRubricsAsync*
        name: GetRubricsAsync
        nameWithType: IForumService.GetRubricsAsync
        qualifiedName: BLL.IForumService.GetRubricsAsync
      VB:
      - id: BLL.IForumService.GetRubricsAsync*
        name: GetRubricsAsync
        nameWithType: IForumService.GetRubricsAsync
        qualifiedName: BLL.IForumService.GetRubricsAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.GetRubricsAsync
  BLL.IForumService.GetTopicByIdAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.GetTopicByIdAsync*
        name: GetTopicByIdAsync
        nameWithType: IForumService.GetTopicByIdAsync
        qualifiedName: BLL.IForumService.GetTopicByIdAsync
      VB:
      - id: BLL.IForumService.GetTopicByIdAsync*
        name: GetTopicByIdAsync
        nameWithType: IForumService.GetTopicByIdAsync
        qualifiedName: BLL.IForumService.GetTopicByIdAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.GetTopicByIdAsync
  BLL.IForumService.GetTopicsAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.GetTopicsAsync*
        name: GetTopicsAsync
        nameWithType: IForumService.GetTopicsAsync
        qualifiedName: BLL.IForumService.GetTopicsAsync
      VB:
      - id: BLL.IForumService.GetTopicsAsync*
        name: GetTopicsAsync
        nameWithType: IForumService.GetTopicsAsync
        qualifiedName: BLL.IForumService.GetTopicsAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.GetTopicsAsync
  BLL.IForumService.GetTopicsByRubricIdAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.GetTopicsByRubricIdAsync*
        name: GetTopicsByRubricIdAsync
        nameWithType: IForumService.GetTopicsByRubricIdAsync
        qualifiedName: BLL.IForumService.GetTopicsByRubricIdAsync
      VB:
      - id: BLL.IForumService.GetTopicsByRubricIdAsync*
        name: GetTopicsByRubricIdAsync
        nameWithType: IForumService.GetTopicsByRubricIdAsync
        qualifiedName: BLL.IForumService.GetTopicsByRubricIdAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.GetTopicsByRubricIdAsync
  BLL.IForumService.ModifyReplyAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.ModifyReplyAsync*
        name: ModifyReplyAsync
        nameWithType: IForumService.ModifyReplyAsync
        qualifiedName: BLL.IForumService.ModifyReplyAsync
      VB:
      - id: BLL.IForumService.ModifyReplyAsync*
        name: ModifyReplyAsync
        nameWithType: IForumService.ModifyReplyAsync
        qualifiedName: BLL.IForumService.ModifyReplyAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.ModifyReplyAsync
  BLL.IForumService.ModifyRubricAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.ModifyRubricAsync*
        name: ModifyRubricAsync
        nameWithType: IForumService.ModifyRubricAsync
        qualifiedName: BLL.IForumService.ModifyRubricAsync
      VB:
      - id: BLL.IForumService.ModifyRubricAsync*
        name: ModifyRubricAsync
        nameWithType: IForumService.ModifyRubricAsync
        qualifiedName: BLL.IForumService.ModifyRubricAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.ModifyRubricAsync
  BLL.IForumService.ModifyTopicAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.ModifyTopicAsync*
        name: ModifyTopicAsync
        nameWithType: IForumService.ModifyTopicAsync
        qualifiedName: BLL.IForumService.ModifyTopicAsync
      VB:
      - id: BLL.IForumService.ModifyTopicAsync*
        name: ModifyTopicAsync
        nameWithType: IForumService.ModifyTopicAsync
        qualifiedName: BLL.IForumService.ModifyTopicAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.ModifyTopicAsync
  BLL.IForumService.DetailTopicsAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.DetailTopicsAsync*
        name: DetailTopicsAsync
        nameWithType: IForumService.DetailTopicsAsync
        qualifiedName: BLL.IForumService.DetailTopicsAsync
      VB:
      - id: BLL.IForumService.DetailTopicsAsync*
        name: DetailTopicsAsync
        nameWithType: IForumService.DetailTopicsAsync
        qualifiedName: BLL.IForumService.DetailTopicsAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.DetailTopicsAsync
  BLL.IForumService.DetailTopicByIdAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.DetailTopicByIdAsync*
        name: DetailTopicByIdAsync
        nameWithType: IForumService.DetailTopicByIdAsync
        qualifiedName: BLL.IForumService.DetailTopicByIdAsync
      VB:
      - id: BLL.IForumService.DetailTopicByIdAsync*
        name: DetailTopicByIdAsync
        nameWithType: IForumService.DetailTopicByIdAsync
        qualifiedName: BLL.IForumService.DetailTopicByIdAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.DetailTopicByIdAsync
  BLL.IForumService.DetailRubricsAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.DetailRubricsAsync*
        name: DetailRubricsAsync
        nameWithType: IForumService.DetailRubricsAsync
        qualifiedName: BLL.IForumService.DetailRubricsAsync
      VB:
      - id: BLL.IForumService.DetailRubricsAsync*
        name: DetailRubricsAsync
        nameWithType: IForumService.DetailRubricsAsync
        qualifiedName: BLL.IForumService.DetailRubricsAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.DetailRubricsAsync
  BLL.IForumService.DetailRubricByIdAsync*:
    name:
      CSharp:
      - id: BLL.IForumService.DetailRubricByIdAsync*
        name: DetailRubricByIdAsync
        nameWithType: IForumService.DetailRubricByIdAsync
        qualifiedName: BLL.IForumService.DetailRubricByIdAsync
      VB:
      - id: BLL.IForumService.DetailRubricByIdAsync*
        name: DetailRubricByIdAsync
        nameWithType: IForumService.DetailRubricByIdAsync
        qualifiedName: BLL.IForumService.DetailRubricByIdAsync
    isDefinition: true
    commentId: Overload:BLL.IForumService.DetailRubricByIdAsync
  System.Threading.Tasks.Task{System.String}:
    name:
      CSharp:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Threading.Tasks.Task`1
        name: Task
        nameWithType: Task
        qualifiedName: System.Threading.Tasks.Task
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Threading.Tasks.Task`1
    parent: System.Threading.Tasks
    commentId: T:System.Threading.Tasks.Task{System.String}
  BLL.ISecurityService.SigningAsync*:
    name:
      CSharp:
      - id: BLL.ISecurityService.SigningAsync*
        name: SigningAsync
        nameWithType: ISecurityService.SigningAsync
        qualifiedName: BLL.ISecurityService.SigningAsync
      VB:
      - id: BLL.ISecurityService.SigningAsync*
        name: SigningAsync
        nameWithType: ISecurityService.SigningAsync
        qualifiedName: BLL.ISecurityService.SigningAsync
    isDefinition: true
    commentId: Overload:BLL.ISecurityService.SigningAsync
  BLL.ISecurityService:
    name:
      CSharp:
      - id: BLL.ISecurityService
        name: ISecurityService
        nameWithType: ISecurityService
        qualifiedName: BLL.ISecurityService
      VB:
      - id: BLL.ISecurityService
        name: ISecurityService
        nameWithType: ISecurityService
        qualifiedName: BLL.ISecurityService
    isDefinition: true
    parent: BLL
    commentId: T:BLL.ISecurityService
  Microsoft.Extensions.Configuration:
    name:
      CSharp:
      - name: Microsoft.Extensions.Configuration
        nameWithType: Microsoft.Extensions.Configuration
        qualifiedName: Microsoft.Extensions.Configuration
        isExternal: true
      VB:
      - name: Microsoft.Extensions.Configuration
        nameWithType: Microsoft.Extensions.Configuration
        qualifiedName: Microsoft.Extensions.Configuration
    isDefinition: true
    commentId: N:Microsoft.Extensions.Configuration
  Microsoft.Extensions.Configuration.IConfiguration:
    name:
      CSharp:
      - id: Microsoft.Extensions.Configuration.IConfiguration
        name: IConfiguration
        nameWithType: IConfiguration
        qualifiedName: Microsoft.Extensions.Configuration.IConfiguration
        isExternal: true
      VB:
      - id: Microsoft.Extensions.Configuration.IConfiguration
        name: IConfiguration
        nameWithType: IConfiguration
        qualifiedName: Microsoft.Extensions.Configuration.IConfiguration
        isExternal: true
    isDefinition: true
    parent: Microsoft.Extensions.Configuration
    commentId: T:Microsoft.Extensions.Configuration.IConfiguration
  BLL.SecurityService.#ctor*:
    name:
      CSharp:
      - id: BLL.SecurityService.#ctor*
        name: SecurityService
        nameWithType: SecurityService.SecurityService
        qualifiedName: BLL.SecurityService.SecurityService
      VB:
      - id: BLL.SecurityService.#ctor*
        name: SecurityService
        nameWithType: SecurityService.SecurityService
        qualifiedName: BLL.SecurityService.SecurityService
    isDefinition: true
    commentId: Overload:BLL.SecurityService.#ctor
  BLL.SecurityService.SigningAsync*:
    name:
      CSharp:
      - id: BLL.SecurityService.SigningAsync*
        name: SigningAsync
        nameWithType: SecurityService.SigningAsync
        qualifiedName: BLL.SecurityService.SigningAsync
      VB:
      - id: BLL.SecurityService.SigningAsync*
        name: SigningAsync
        nameWithType: SecurityService.SigningAsync
        qualifiedName: BLL.SecurityService.SigningAsync
    isDefinition: true
    commentId: Overload:BLL.SecurityService.SigningAsync
  BLL.ISecurityService.SigningAsync(System.String,System.String):
    name:
      CSharp:
      - id: BLL.ISecurityService.SigningAsync(System.String,System.String)
        name: SigningAsync
        nameWithType: ISecurityService.SigningAsync
        qualifiedName: BLL.ISecurityService.SigningAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
      VB:
      - id: BLL.ISecurityService.SigningAsync(System.String,System.String)
        name: SigningAsync
        nameWithType: ISecurityService.SigningAsync
        qualifiedName: BLL.ISecurityService.SigningAsync
      - name: (
        nameWithType: (
        qualifiedName: (
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: ', '
        nameWithType: ', '
        qualifiedName: ', '
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    parent: BLL.ISecurityService
    commentId: M:BLL.ISecurityService.SigningAsync(System.String,System.String)
  System.Collections.Generic.List`1:
    name:
      CSharp:
      - id: System.Collections.Generic.List`1
        name: List
        nameWithType: List
        qualifiedName: System.Collections.Generic.List
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - name: T
        nameWithType: T
        qualifiedName: T
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Collections.Generic.List`1
        name: List
        nameWithType: List
        qualifiedName: System.Collections.Generic.List
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - name: T
        nameWithType: T
        qualifiedName: T
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: true
    commentId: T:System.Collections.Generic.List`1
  System.Collections.Generic:
    name:
      CSharp:
      - name: System.Collections.Generic
        nameWithType: System.Collections.Generic
        qualifiedName: System.Collections.Generic
        isExternal: true
      VB:
      - name: System.Collections.Generic
        nameWithType: System.Collections.Generic
        qualifiedName: System.Collections.Generic
    isDefinition: true
    commentId: N:System.Collections.Generic
  System.Collections.Generic.List{System.String}:
    name:
      CSharp:
      - id: System.Collections.Generic.List`1
        name: List
        nameWithType: List
        qualifiedName: System.Collections.Generic.List
        isExternal: true
      - name: <
        nameWithType: <
        qualifiedName: <
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: '>'
        nameWithType: '>'
        qualifiedName: '>'
      VB:
      - id: System.Collections.Generic.List`1
        name: List
        nameWithType: List
        qualifiedName: System.Collections.Generic.List
        isExternal: true
      - name: '(Of '
        nameWithType: '(Of '
        qualifiedName: '(Of '
      - id: System.String
        name: String
        nameWithType: String
        qualifiedName: System.String
        isExternal: true
      - name: )
        nameWithType: )
        qualifiedName: )
    isDefinition: false
    definition: System.Collections.Generic.List`1
    parent: System.Collections.Generic
    commentId: T:System.Collections.Generic.List{System.String}
  BLL.SecurityService.GenerateJwtToken*:
    name:
      CSharp:
      - id: BLL.SecurityService.GenerateJwtToken*
        name: GenerateJwtToken
        nameWithType: SecurityService.GenerateJwtToken
        qualifiedName: BLL.SecurityService.GenerateJwtToken
      VB:
      - id: BLL.SecurityService.GenerateJwtToken*
        name: GenerateJwtToken
        nameWithType: SecurityService.GenerateJwtToken
        qualifiedName: BLL.SecurityService.GenerateJwtToken
    isDefinition: true
    commentId: Overload:BLL.SecurityService.GenerateJwtToken
  BLL.SecurityService:
    name:
      CSharp:
      - id: BLL.SecurityService
        name: SecurityService
        nameWithType: SecurityService
        qualifiedName: BLL.SecurityService
      VB:
      - id: BLL.SecurityService
        name: SecurityService
        nameWithType: SecurityService
        qualifiedName: BLL.SecurityService
    isDefinition: true
    commentId: T:BLL.SecurityService
