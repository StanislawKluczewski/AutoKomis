# AutoKomis

AutoKomis is a project that allows You to manage selling and importing cars.
You can develop and change the code in a very real sense.

## License

[MIT](https://choosealicense.com/licenses/mit/)


## Authors

- [@StanislawKluczewski](https://github.com/StanislawKluczewski)


## Technological description

Used Technologies:
ASP.NET MVC, Bootstrap, Razor Pages

Available on Windows.

## API Reference

### Auto 
##### Get the view of creating car

```http
  GET /CreateAuto
```

##### Create car

```http
  POST /CreateAuto
```

##### Get the view of editing car by id

```http
  GET /Auto/UpdateAuto/{id}
```

##### Edit car by id

```http
  POST /Auto/UpdateAuto/{id}
```
##### Delete car by name

```http
  DELETE /DeleteAuto
```

##### Get Car by given parameters

```http
  GET /ZnajdzAutoOdpowiednieParametry
```

##### Get the available cars

```http
  GET /SzukajDostepnychSamochodow
```


### Sales 
##### Get the view of creating sales
```http
  GET /CreateSprzedazGet
```

##### Create sales
```http
  POST /CreateSprzedazPost
```

##### Get the view of updating the sales 

```http
  GET /UpdateSprzedaz
```

##### Update of Sales

```http
  POST /UpdateSprzedaz
```

##### Delete sales

```http
  GET /[Sprzedaz]/DeleteSprzedaz/{id}
```

##### Look for sales

```http
  GET /SzukajSprzedaży
```

### Worker

##### Get the view of creating worker
```http
  GET /CreatePracownik
```

##### Create worker
```http
  POST /CreatePracownik
```

##### Get the view of updating the worker
```http
  GET /UpdatePracownik
```

##### Update of worker

```http
  POST /UpdatePracownik
```

##### Get the view of  Delete worker

```http
  GET /DeletePracownik
```
##### Delete worker by id

```http
  POST Pracownik/DeletePracownikPost/{id}
```
##### Look for worker

```http
  GET /ZnajdzPracownika
```
