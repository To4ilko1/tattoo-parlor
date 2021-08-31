# Тату салон.
Данный проект — это оконное приложение на C#, предназначенная автоматизации процессов и повышения эффективности работы тату салона. Она автоматизирует основные операции, связанные с данной предметной областью. Программа предназначена для работы с клиентами, мастерами, заказами, филиалами и услугами тату салона. Используется Entity Framework.
## Диаграмма размещения
![](https://github.com/To4ilko1/TattooParlor/blob/main/resources/Диаграмма%20размещения.jpg "Диаграмма размещения")
Диаграмма размещения отражает физические взаимосвязи между программными и аппаратными компонентами системы. 
На диаграмме размещения изображены узлы выполнения программных компонентов, а также объектов. 
Показано, что клиентское приложение, установленное на компьютере пользователя, 
взаимодействует с сервером, который содержит в себе базу данных.
## Диаграмма компонентов
![](https://github.com/To4ilko1/TattooParlor/blob/main/resources/Диаграмма%20компонентов.jpg "Диаграмма компонентов")
На данной диаграмме изображены все компоненты: клиентское приложение, сеансы, мастера, клиенты, услуги, филиалы, материалы, кабинеты, платежи.
Эти компоненты взаимодействуют друг с другом с помощью интерфейсов.
## Диаграммы интерфейсов
![](https://github.com/To4ilko1/TattooParlor/blob/main/resources/Диаграмма%20интерфейсов%5B1%5D.jpg "Диаграмма интерфейсов")
![](https://github.com/To4ilko1/TattooParlor/blob/main/resources/Диаграмма%20интерфейсов%5B2%5D.jpg "Диаграмма интерфейсов")
## Список всех интерфейсов
* [IWorker](https://github.com/To4ilko1/TattooParlor/blob/main/docs/IWorker.md "Интерфейс IWorker")
* [IClient](https://github.com/To4ilko1/TattooParlor/blob/main/docs/IClient.md "Интерфейс IClient")
* [IService](https://github.com/To4ilko1/TattooParlor/blob/main/docs/IService.md "Интерфейс IService")
* [ISession](https://github.com/To4ilko1/TattooParlor/blob/main/docs/ISession.md "Интерфейс ISession")
* [IBranch](https://github.com/To4ilko1/TattooParlor/blob/main/docs/IBranch.md "Интерфейс IBranch")
* [ICabinet](https://github.com/To4ilko1/TattooParlor/blob/main/docs/ICabinet.md "Интерфейс ICabinet")
* [IPay](https://github.com/To4ilko1/TattooParlor/blob/main/docs/IPay.md "Интерфейс IPay")
* [IMaterial](https://github.com/To4ilko1/TattooParlor/blob/main/docs/IMaterial.md "Интерфейс IMaterial")
* [IWorkingHour](https://github.com/To4ilko1/TattooParlor/blob/main/docs/IWorkingHour.md "Интерфейс IWorkingHour")
