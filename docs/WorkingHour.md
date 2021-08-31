# Описание класса WorkingHour
Класс для работы с расписанием сотрудников тату-салона.

## Атрибуты

* ID:Int
* Branch:[Branch](https://github.com/To4ilko1/tattoo-parlor/blob/master/docs/Branch.md "объект класса Branch")
* Worker:[Worker](https://github.com/To4ilko1/tattoo-parlor/blob/master/docs/Worker.md "объект класса Worker")
* TimeEnd:DateTime
* TimeStart:DateTime
* DeleteTime:DateTime

## Описание атрибутов

* ID:Int - идентификатор в БД.
* Branch:[Branch](https://github.com/To4ilko1/tattoo-parlor/blob/master/docs/Branch.md "объект класса Branch") - филиал.
* Worker:[Worker](https://github.com/To4ilko1/tattoo-parlor/blob/master/docs/Worker.md "объект класса Worker") - сотрудник.
* TimeEnd:DateTime - дата окончания.
* TimeStart:DateTime - дата начала.
* DeleteTime:DateTime - дата удаления.