# Dicionario-Grego-Backend

<div>
<img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
<img src="https://img.shields.io/badge/SQLite-07405E?style=for-the-badge&logo=sqlite&logoColor=white" />
</div>

### .NET, SQLite, Entity Framework, Automapper

# Abouth the project

https://dicionariogrego.com

Dicionariogrego.com is a digitalized version of the Dictionary Greek-Portuguese by Isidro Pereira, 
the dataset for this project was built using Tesseract OCR, the data was filtered and reviewed with python scripts to ensure the 
diacritics where in the correct place. <br>The dataset was also proofread to ensure the scripts ran accordingly.

## Steps to Setup

**1. Clone the application**

```bash
git clone https://github.com/AbidielChagas/Dicionario-Grego-Backend.git
```

**2. Run the app using dotnet**

```bash
dotnet watch run
```
The app will start running at <http://localhost:5000>

### Method

| Method | Url | Description | Sample Valid Request Body |
| ------ | --- | ----------- | ------------------------- |
| POST    | /{query} | Get all the word containing the query element by alphabetical order | λαβυρινθος

Test it using Swagger or any other rest client.

## Sample JSON Response Body

##### <a id="signup">POST -> /{query}
```json
 {
    "searchable": "λαβυρινθος",
    "name": "Λαβύρινθος",
    "etimology": "",
    "type": "Substantivo",
    "gender": "Masculino",
    "meaning": " labirinto",
    "inflection": null,
    "observation": null
  }
```
