Esses pacotes  serão adicionados ao Projeto para  poder trabalhar com 
os recursos do EntityFrameworkCore como as Migrations 
usando o Code First para criação do Modelo do Negócio.
As regras de Negócio como Relacionamentos entre Entidades será feito 
dentro do Model do projeto 
O uso do Banco adotado será o Banco SqlServer para realização dos
métodos de acesso a dados .
Será uma pequena Api pensando no modelo Academico de Universidades .
*Será usado também o uso do Swagger para Ver o Funcionamento dos métodos ,
claramente poderia ser usado o PostMan também sem uso do Swagger más para este 
caso de exemplo será com Swagger .
*Para Essa aplicação ainda não estará com o pacote Jwt para geração de Token .
*Aplicação para fins de Estudo com a tecnologia .
*Para esta aplicação tentarei usar o padrão de projeto Repository Pattern aprendido com 
formações online com a Plataforma Balta.io que recomendo estudos a toda Comunidade .
Será aplicado para testar o aprendizado com o conteúdo.


dotnet add package Microsoft.EntityFrameworkCore --version 3.1.14
dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.14
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.14