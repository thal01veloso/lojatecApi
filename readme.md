Banco de dados:
    MySql
> Este projeto estava dando o erro de caminho do CSPROJ. foi solucionado trocando a versão do pacote entity framework de 5.0.1 para 3.1.9

Para ver os campos da tabela do sql
SHOW COLUMNS FROM [nome da tabela];

 dotnet ef migrations add Inicial 
 > Adiciona uma migração inical do banco de dados
    > é criado uma pasta chamada migrations no projeto:
    > Usando p pomelo como biblioteca do entity as verções que não dão erro são:
                    PackageReference Include="Microsoft.EntityFrameworkCore" Version="3.1.9" />
                <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="3.1.9">
                <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
                <PrivateAssets>all</PrivateAssets>
                </PackageReference>
                <PackageReference Include="Microsoft.EntityFrameworkCore.Relational" Version="3.1.9" />
                <PackageReference Include="Microsoft.EntityFrameworkCore.sqlserver" Version="3.1.9" />
                <PackageReference Include="Microsoft.EntityFrameworkCore.tools" Version="3.1.9">
                <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
                <PrivateAssets>all</PrivateAssets>
                </PackageReference>
                <PackageReference Include="MySql.Data" Version="8.0.23" />
                <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="3.2.3" />
                <PackageReference Include="Pomelo.EntityFrameworkCore.MySql.Design" Version="1.1.2" />
                <PackageReference Include="Swashbuckle.AspNetCore" Version="5.6.3" /
 dotnet ef database update
 > Aplica a migração
 dotnet ef migrations script
 > Cria um script sql para a migração
 dotnet ef database drop
 > Apaga o bando de dados
 
 --->>---->> No comando abaixo foi criado mais uma coluna/propriedade na Entidade(Entity) e foi utilizado so seguintes comandos para atualizar o banco de dados criado-----<<---------<<--------

 dotnet ef migrations add AddColumnCor
 >Adiciona a migração da coluna Cor criada depois na entidade. Foi colocado o nome de "AddColumnCor"
 dotnet ef database update addColumnCor
 > Atualiza o banco de dados para a ultima migração que foi a "AddColumnCor"