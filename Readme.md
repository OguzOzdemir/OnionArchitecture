## Getting Started

The Onion Architecture term was coined by Jeffrey Palermo in 2008. This architecture provides a better way to build applications for better testability, maintainability, and dependability on the infrastructures like databases and services. This architecture's main aim is to address the challenges faced with 
3-tier architecture or n-tier architecture and to provide a solution for common problems, like coupling and separation of concerns.

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>


### Advantages of Onion Architecture

There are several advantages of the Onion Architecture, as listed below.


* It provides better maintainability as all the codes depend on layers or the center.
* It provides better testability as the unit test can be created for separate layers without an effect of other modules of the application.
* It develops a loosely coupled application as the outer layer of the application always communicates with the inner layer via interfaces.
* Any concrete implantation would be provided to the application at run time
* Domain entities are core and center part. It can have access to both the database and UI layers.
* The internal layers never depend on the external layer. The code that may have changed should be part of an external layer.



  ![alt text](https://i.ibb.co/DKRp0bL/Onion-Architecture.png)