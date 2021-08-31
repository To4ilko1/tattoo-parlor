# Описание класса Session
Класс для работы с сеансами тату-салона.

## Атрибуты

* ID:Int
* Client:[Client](https://github.com/To4ilko1/tattoo-parlor/blob/master/docs/Client.md "объект класса Client")
* Date:DateTime
* TimeStart:DateTime
* TimeEnd:DateTime
* Price:Double
* Branch:[Branch](https://github.com/To4ilko1/tattoo-parlor/blob/master/docs/Branch.md "объект класса Branch")
* CountWorker:Int
* ReduceMaterial:Bool
* DeleteTime:DateTime

## Описание атрибутов

* ID:Int - идентификатор в БД.
* Client:[Client](https://github.com/To4ilko1/tattoo-parlor/blob/master/docs/Client.md "объект класса Client") - клиент.
* Date:DateTime - дата сеанса.
* TimeStart:DateTime - время начала.
* TimeEnd:DateTime - время конца.
* Price:Double - стоимость.
* Branch:[Branch](https://github.com/To4ilko1/tattoo-parlor/blob/master/docs/Branch.md "объект класса Branch") - филиал, в котором проходит сеанс.
* CountWorker:Int - количество мастеров.
* ReduceMaterial:Bool - уменьшение количества материала.
* DeleteTime:DateTime - дата удаления.