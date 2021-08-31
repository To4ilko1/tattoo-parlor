# Описание класса Worker
Класс для работы с сотрудниками тату-салона.

## Атрибуты

* ID:Int
* LastName:String
* Name:String
* SecondName:String
* Position:String
* TattooStyle:String
* Experience:Int
* ContactPhoneNumber:String
* Comment:String
* Login:String
* Password:String
* Branch:[Branch](https://github.com/To4ilko1/TattooParlor/blob/master/docs/Branch.md "объект класса Branch")
* DeleteTime:DateTime

## Описание атрибутов

* ID:Int - идентификатор в БД.
* LastName:String - отчество сотрудника.
* Name:String - имя сотрудника.
* SecondName:String - фамилия сотрудника.
* Position:String - должность сотрудника.
* TattooStyle:String - стиль татуировки.
* Experience:Int - опыт.
* ContactPhoneNumber:String - мобильный телефон.
* Comment:String - описание.
* Login:String - логин.
* Password:String - пароль.
* Branch:[Branch](https://github.com/To4ilko1/TattooParlor/blob/master/docs/Branch.md "объект класса Branch") - филиал, в котором работает сотрудник.
* DeleteTime:DateTime - дата удаления.