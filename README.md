# Api-Clima

Este é um projeto back-end de uma API construída com C# .NET que consome a Weather API (https://www.weatherapi.com/). A Weather API fornece informações sobre o clima atual de uma cidade específica.

## Funcionalidades

- **GET /Clima**: Obtém o clima atual da cidade consultada.

## Tecnologias Utilizadas:

- **.NET 8**
- **ASP.NET Core**: Para construção da API.
- **HttpClient**: Para fazer requisições à WeatherAPI.
- **WeatherAPI**: API pública para obter dados de clima (https://www.weatherapi.com/).

## Endpoints

### `GET /clima/`

Este endpoint retorna o clima atual da cidade informada no parâmetro.

#### Parâmetros

- `city`(string) - **Obrigatório**: Nome da cidade para a qual as informações climáticas serão recuperadas.
- Exemplo de URL: `/api/clima/salvador`

#### Resposta

A resposta será um objeto JSON com as informações do clima atual da cidade especificada assim como o ícone que representa as condições do tempo. Exemplo de resposta onde foi realizado uma consulta utilizando a cidade 'São Paulo':

```json
{
  "city": "Sao Paulo",
  "region": "Sao Paulo",
  "tempCelsius": 21.4,
  "humidity": 73,
  "condition": "Partly cloudy",
  "iconeCondicion": "//cdn.weatherapi.com/weather/64x64/day/116.png",
  "windSpeed": 17.6
}
```

## Funcionalidades

Para utilizar essa API é necessário gerar uma chave de autenticação.

Segue abaixo passos para autenticação:

1- Se cadastre no site através do link https://www.weatherapi.com/signup.aspx

2- Realize a confirmação de cadastro através de link enviado por email e realize login pelo site.

3- Ao ser direcionado para o seu perfil (https://www.weatherapi.com/my/), é possível visualizar o campo API Key que contém o valor da chave a ser utilizada na autenticação, copie o valor desse campo.

4- Acesse o arquivo 'ClimaRepository.cs' disponibilizado no diretório 'Repositories' desse projeto e na linha 9, insira entre as aspas o valor copiado. Por fim, salve as alterações realizadas.

5- Caso deseje utilizar esse projeto em ambiente local, execute o projeto através do comando 'dotnet run' e realize a chamada da url na barra de endereço de seu navegador ou utilizando uma ferramenta de testes como o Postam informando uma cidade como parâmetro. Exemplo de chamada:
http://localhost:5146/api/clima/salvador

