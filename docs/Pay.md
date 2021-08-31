# Описание класса Pay
Класс для работы с платежами тату-салона.

## Атрибуты

* ID:Int
* Client:[Client](https://github.com/To4ilko1/TattooParlor/blob/master/docs/Client.md "объект класса Client")
* Date:DateTime
* Price:Double
* Session:[Session](https://github.com/To4ilko1/TattooParlor/blob/master/docs/Session.md "объект класса Session")
* Worker:[Worker](https://github.com/To4ilko1/TattooParlor/blob/master/docs/Worker.md "объект класса Worker")
* DeleteTime:DateTime

## Описание атрибутов

* ID:Int - идентификатор в БД.
* Client:[Client](https://github.com/To4ilko1/TattooParlor/blob/master/docs/Client.md "объект класса Client") - клиент.
* Date:DateTime - дата платежа.
* Price:Float - сумма.
* Session:[Session](https://github.com/To4ilko1/TattooParlor/blob/master/docs/Session.md "объект класса Session") - сеанс.
* Worker:[Worker](https://github.com/To4ilko1/TattooParlor/blob/master/docs/Worker.md "объект класса Worker") - тату-мастер.
* DeleteTime:DateTime - дата удаления.