# Los principios SOLID
SOLID es un acrónimo de los primeros cinco principios del diseño orientado a objetos (OOD) de Robert C. Martin, también conocido como 
el [Tío Bob](https://en.wikipedia.org/wiki/Robert_C._Martin).

Estos principios establecen prácticas que se prestan al desarrollo de software con consideraciones para su mantenimiento y expansión a medida que el 
proyecto se amplía. Adoptar estas prácticas también puede ayudar a evitar los aromas de código, refactorizar el código y aprender sobre el desarrollo 
ágil y adaptativo de software.

![design_ppx-04](https://user-images.githubusercontent.com/49702007/170388935-6d2a1c8c-6e35-42d9-ab00-50714cd06858.jpg)

## ¿Que son los principios SOLID?
Son recomendaciones a la hora de escribir código en lenguajes de programación orientado a objeto fuertemente tipado para el que código sea más.
> - Mantenible
> - Reutilizable
> - Código limpio
> - Que tenga alta cohesión y bajo acoplamiento

## ¿Que NO son los principios SOLID?
> - Obligatorios

## ¿Por qué los debo de implementar?
> - Evitar código repetido
> - Evitar código espaguetis
> - Escalabilidad
> - Código facil de mantener
> - Ahorra costos de operabilidad

## 1. Principio de Responsabilidad Única
El principio de responsabilidad única (SRP) establece: 
>**Una clase debe tener una y una sola razón para cambiar, lo que significa que una clase debe tener solo un trabajo.**

## 2. Principio abierto-cerrado
Principio abierto-cerrado (S.R.P.) establece: 
>**Los objetos o entidades deben estar abiertos por extensión, pero cerrados por modificación.**

## 3. Principio de sustitución de Liskov
El principio de sustitución de Liskov establece: 
>**Si la clase A es un subtipo de la clase B , deberíamos poder reemplazar B  con  A  sin interrumpir el comportamiento de nuestro programa.**

## 4. Principio de segregación de interfaz
El principio de segregación de interfaz establece: 
>**Un cliente nunca debe ser forzado a implementar una interfaz que no usan ni los clientes no deben ser forzados a depender de métodos que no usan.**

## 5. Principio de inversión de dependencia
El principio de inversión de dependencia establece:
>**Las entidades deben depender de abstracciones, no de concreciones. Indica que el módulo de alto nivel no debe depender del módulo de bajo nivel, sino que deben depender de las abstracciones.**
