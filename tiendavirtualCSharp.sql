-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-12-2014 a las 11:04:36
-- Versión del servidor: 5.5.32
-- Versión de PHP: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `tiendaonline`
--
CREATE DATABASE IF NOT EXISTS `tiendavirtual` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `tiendavirtual`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `almacen`
--

CREATE TABLE IF NOT EXISTS `almacen` (
  `id_Producto` int(5) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Productos` int(3) NOT NULL,
  UNIQUE KEY `id_Producto` (`id_Producto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=101 ;

--
-- Volcado de datos para la tabla `almacen`
--

INSERT INTO `almacen` (`id_Producto`, `Nombre`, `Productos`) VALUES
(1, 'Black Label', 30),
(2, 'Blue Label', 30),
(3, 'Cahuayo', 30),
(4, 'Chivas Regal', 30),
(5, 'Vino Comun', 30),
(6, 'Conde Azul', 30),
(7, 'Domecq', 30),
(8, 'Freixenet', 30),
(9, 'Gran Centenario', 30),
(10, 'Gran Rose', 30),
(11, 'Jose Cuervo', 30),
(12, 'Kahula', 30),
(13, 'Louis XIII', 30),
(14, 'Luxardo', 30),
(15, 'Maipo', 30),
(16, 'Pedro Gil', 30),
(17, 'Perrier Jouet', 30),
(18, 'Ron Barcelo', 30),
(19, 'Sauza', 30),
(20, 'Something', 30),
(21, 'Blusa', 30),
(22, 'Botas', 30),
(23, 'Boxer', 30),
(24, 'Brazier', 30),
(25, 'Chamarra', 30),
(26, 'Corbata', 30),
(27, 'Falda', 30),
(28, 'Huaraches', 30),
(29, 'Leggins', 30),
(30, 'Pantalon', 30),
(31, 'Playera', 30),
(32, 'Saco', 30),
(33, 'Short', 30),
(34, 'Smokin', 30),
(35, 'Sueter', 30),
(36, 'Tenis', 30),
(37, 'Top', 30),
(38, 'Traje de Baño', 30),
(39, 'Vestido', 30),
(40, 'Zapatillas', 30),
(41, 'Anillo', 30),
(42, 'Anillo grueso', 30),
(43, 'Anillo caparazon', 30),
(44, 'Anillo doble', 30),
(45, 'Aretes', 30),
(46, 'Brazalete', 30),
(47, 'Cofre', 30),
(48, 'Collar de oro', 30),
(49, 'Collar', 30),
(50, 'Diadema', 30),
(51, 'Dige', 30),
(52, 'Juego de joyas', 30),
(53, 'Muñequera', 30),
(54, 'Pasador', 30),
(55, 'Percing', 30),
(56, 'Pulsera', 30),
(57, 'Reloj Masculino', 30),
(58, 'Reloj de bolsillo', 30),
(59, 'Reloj femenino', 30),
(60, 'Tobillera', 30),
(61, 'All-in-one', 30),
(62, 'Camara', 30),
(63, 'GPS', 30),
(64, 'Head phone', 30),
(65, 'Laptop', 30),
(66, 'Manos libres', 30),
(67, 'Mouse', 30),
(68, 'Multifuncional', 30),
(69, 'Plataforma tablet', 30),
(70, 'Proyector', 30),
(71, 'Servidor Web', 30),
(72, 'Smart phone', 30),
(73, 'Smart watch', 30),
(74, 'Tablet', 30),
(75, 'USB', 30),
(76, 'Video-camara', 30),
(77, 'Web-cam', 30),
(78, 'Wii U', 30),
(79, 'Windows surface', 30),
(80, 'Xbox 360', 30),
(81, 'Alhondigas', 30),
(82, 'Brochetas', 30),
(83, 'Carne asada', 30),
(84, 'Chocolate', 30),
(85, 'Crepas', 30),
(86, 'Donas', 30),
(87, 'Flan', 30),
(88, 'Flautas', 30),
(89, 'Gelatina', 30),
(90, 'Hamburguesa', 30),
(91, 'Hot-cakes', 30),
(92, 'Hot-Dog', 30),
(93, 'Mufin', 30),
(94, 'Nieves', 30),
(95, 'Pan', 30),
(96, 'Papas a la francesa', 30),
(97, 'Pastel', 30),
(98, 'Pay', 30),
(99, 'Pizza', 30),
(100, 'Tacos', 30);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `carrito`
--

CREATE TABLE IF NOT EXISTS `carrito` (
  `id_Carrito` int(5) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Precio` double(10,2) NOT NULL,
  `TotalProducto` int(5) NOT NULL,
  `id_Cliente` int(5) NOT NULL,
  UNIQUE KEY `id_Carrito` (`id_Carrito`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE IF NOT EXISTS `categorias` (
  `id_Categoria` int(5) NOT NULL AUTO_INCREMENT,
  `Nombre_Categoria` varchar(20) NOT NULL,
  PRIMARY KEY (`id_Categoria`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id_Categoria`, `Nombre_Categoria`) VALUES
(1, 'Comidas'),
(2, 'Ropa'),
(3, 'Joyas'),
(4, 'Tecnologia'),
(5, 'Vinos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE IF NOT EXISTS `productos` (
  `id_Producto` int(5) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,
  `Precio` double(10,2) NOT NULL,
  `Categoria` int(5) NOT NULL,
  `RutaImagen` varchar(100) NOT NULL,
  UNIQUE KEY `id_Producto` (`id_Producto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=101 ;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id_Producto`, `Nombre`, `Descripcion`, `Precio`, `Categoria`, `RutaImagen`) VALUES
(1, 'Black Label', 'Añejado hace 15 años, categoria media', 459.00, 5, 'vinos/blackLabel.jpg'),
(2, 'Blue Label', 'Añejado hace 25 años, categoria media-alta', 876.50, 5, 'vinos/blueLabel.jpg'),
(3, 'Cahuayo', 'Vino hecho con las mejores uvas del mundo', 570.00, 5, 'vinos/cahuayo.jpg'),
(4, 'Chivas Regal', 'Tequila elaborado en Inglaterra', 654.00, 5, 'vinos/chivasRegal.jpg'),
(5, 'Vino Comun', 'Vino con mayor tradicion en España', 322.50, 5, 'vinos/comun.jpg'),
(6, 'Conde Azul', 'Tequila de oro blanco, dorado y cobrizo', 863.50, 5, 'vinos/condeAzul.jpg'),
(7, 'Domecq', 'Vino elaborado por personas pulcras 100%', 700.00, 5, 'vinos/domecq.jpg'),
(8, 'Freixenet', 'Tequila 100% mexicano elaborado en Oaxaca', 500.00, 5, 'vinos/Freixenet.jpg'),
(9, 'Gran Centenario', '100 años de añejamiento chileno', 600.00, 5, 'vinos/granCentenario.jpg'),
(10, 'Gran Rose', 'Vinos de diferentes frutas frescas de temporada', 400.00, 5, 'vinos/granRose.jpg'),
(11, 'Jose Cuervo', 'El mas comun para competir por liderato', 550.00, 5, 'vinos/joseCuervo.jpg'),
(12, 'Kahula', 'Vino a base de uvas con vainilla', 437.50, 5, 'vinos/Kahula.jpg'),
(13, 'Louis XIII', 'Rey de los tequilas pero al mas alto costo', 9844.00, 5, 'vinos/louisXIII.jpg'),
(14, 'Luxardo', 'Vino elaborado con pulpa de tamarindo', 399.99, 5, 'vinos/luxardo.jpg'),
(15, 'Maipo', 'Champagne al puro estilo Indu', 650.00, 5, 'vinos/maipo.jpg'),
(16, 'Pedro Gil', 'El vino mexicano por excelencia', 628.30, 5, 'vinos/pedroGil.jpg'),
(17, 'Perrier Jouet', 'Vino tinto ecologico por botellas recicladas', 840.00, 5, 'vinos/PerrierJouet.jpg'),
(18, 'Ron Barcelo', 'No existe mejor ron que este', 444.10, 5, 'vinos/ronBarcelo.jpg'),
(19, 'Sauza', 'Directamente de Culiacan Mexico el tequila mas fuerte', 892.00, 5, 'vinos/sauza.jpg'),
(20, 'Something', '40% tequila, 50% vino y el resto agua', 990.90, 5, 'vinos/something.jpg'),
(21, 'All-in-one', '500Gb HDD, 8Gb RAM, 4 nucleos, 2 USB 3.0', 8250.00, 4, 'computacion/allinone.jpg'),
(22, 'Camara', 'Memoria interna 4Gb, 24x zoom', 3050.30, 4, 'computacion/camara.jpg'),
(23, 'GPS', 'Windows 7 y conectado a internet todo el tiempo', 2136.50, 4, 'computacion/gps.jpg'),
(24, 'Head phone', 'Conexion bluethoot con diamantes de fantasia', 354.00, 4, 'computacion/headPhone.jpg'),
(25, 'Laptop', 'Ferrary con Windows Vista, 4Gb RAM', 5600.90, 4, 'computacion/laptop.jpg'),
(26, 'Manos libres', 'Kit de microfono mas audifonos', 325.50, 4, 'computacion/manoslibres.jpg'),
(27, 'Mouse', 'Luz led con estabilizador lazer', 57.30, 4, 'computacion/mouse.jpg'),
(28, 'Multifuncional', 'Imprime, escanea, usa fax, llama, has fotografias', 2500.00, 4, 'computacion/multifuncional.jpg'),
(29, 'Plataforma tablet', 'Se puede usar como mesa. S.O. Windows 8', 7430.00, 4, 'computacion/plataform-tablet.jpg'),
(30, 'Proyector', 'Compacto con entrada HDMI y VGA', 930.00, 4, 'computacion/proyector.jpg'),
(31, 'Servidor Web', '1Tb de transferencia mensual, 5Tb HDD, auto-enfriamento', 10199.99, 4, 'computacion/server.jpg'),
(32, 'Smart phone', 'Galaxy S3, Quad-core, 3Gb RAM', 5888.90, 4, 'computacion/smartphone.jpg'),
(33, 'Smart watch', 'Gorilla glass, Android 4.1, 1Gb RAM', 3339.99, 4, 'computacion/smartwatch.jpg'),
(34, 'Tablet', 'Asus con sistema de enfriamento, mantalla capacitiva', 6630.99, 4, 'computacion/tablet.jpg'),
(35, 'USB', 'DGT 100 de 8Gb Marca Kingston', 150.00, 4, 'computacion/usb.jpg'),
(36, 'Video-camara', '45x zoom, 8Gb memoria interna', 1199.30, 4, 'computacion/videocamara.jpg'),
(37, 'Web-cam', 'Producida por Lighshot ideal para acercamientos', 253.00, 4, 'computacion/webcam.jpg'),
(38, 'Wii U', 'Super portatil y mega divertido, lo mejor en interfaz motriz', 4327.10, 4, 'computacion/wiiU.jpg'),
(39, 'Windows surface', 'Capaz de ser Tablet y Laptop. Ideal para jovenes', 8010.00, 4, 'computacion/windowsSurface.jpg'),
(40, 'Xbox 360', 'Slim con 160 HDD, un control alambrico y membresia Gold por 1 año', 8300.90, 4, 'computacion/xbox360.jpg'),
(41, 'Blusa', 'Escote lineal ideal para fiestas casuales', 250.00, 2, 'ropa/blusa.jpg'),
(42, 'Botas', 'Piel de cocodrilo, ideal para no mojarse', 950.30, 2, 'ropa/botas.jpg'),
(43, 'Boxer', 'MAsculino de algodon, para evitar rosaduras', 36.50, 2, 'ropa/boxer.jpg'),
(44, 'Brazier', 'Encaje de plata para danza arabe', 54.00, 2, 'ropa/brazier.jpg'),
(45, 'Chamarra', 'Piel de borrego, soporta bajas temperaturas', 1300.90, 2, 'ropa/chamarra.jpg'),
(46, 'Corbata', 'Lineas azul fuerte y azul bajo, terciopelo 100%', 25.50, 2, 'ropa/corbata.jpg'),
(47, 'Falda', 'Para niñas, jovencitas y señoras, no importa la edad', 156.30, 2, 'ropa/falda.jpg'),
(48, 'Huaraches', 'De cuero confeccionados en Leon Guanajuato', 500.00, 2, 'ropa/huaraches.jpg'),
(49, 'Leggins', 'Estirables tipo mezclilla', 4300.00, 2, 'ropa/leggins.jpg'),
(50, 'Pantalon', 'De mesclilla marca Levis', 230.00, 2, 'ropa/pantalon.jpg'),
(51, 'Playera', 'Algodon con polyester marca AeroPostal', 100.00, 2, 'ropa/playera.jpg'),
(52, 'Saco', 'Para caballero de terciopelo. No incluye corbata', 688.90, 2, 'ropa/saco.jpg'),
(53, 'Short', 'Perfecto para ir a la plaa. Dobre vista', 139.99, 2, 'ropa/short.jpg'),
(54, 'Smokin', 'La mejor gamusa es usada en este conjunto', 1630.99, 2, 'ropa/smokin.jpg'),
(55, 'Sueter', 'Tejido a mano por las mejores costureras de Mexico', 650.00, 2, 'ropa/sueter.jpg'),
(56, 'Tenis', 'Marca nike estilo bota. Perfecto para invierno', 899.30, 2, 'ropa/tenis.jpg'),
(57, 'Top', 'Para niñas de 8 - 14 años. Algodon 100%', 53.00, 2, 'ropa/top.jpg'),
(58, 'Traje de Baño', 'Juego completo, de latex para mejor ajuste', 327.10, 2, 'ropa/trajeBaño.jpg'),
(59, 'Vestido', 'El vestido de Paris Hilton sin hombreras', 1010.00, 2, 'ropa/vestido.jpg'),
(60, 'Zapatillas', 'Cabian de color dependiendo la ocacion', 990.90, 2, 'ropa/zapatillas.jpg'),
(61, 'Anillo', 'Plata tipo enlaces', 1250.00, 3, 'joyas/anillo.jpg'),
(62, 'Anillo grueso', 'Plata con incrustaciones de diamantes', 1950.30, 3, 'joyas/anillo2.jpg'),
(63, 'Anillo caparazon', 'De oro con grabado en alto relieve', 1136.50, 3, 'joyas/anillo3.jpg'),
(64, 'Anillo doble', 'Tipo torre oro normal y oro blanco', 1354.00, 3, 'joyas/anilloDoble.jpg'),
(65, 'Aretes', '2 rubys azules cada uno', 1600.90, 3, 'joyas/arete.jpg'),
(66, 'Brazalete', 'Acero inoxidable bañado en oro', 925.50, 3, 'joyas/brazalete.jpg'),
(67, 'Cofre', 'Paredes de cristal idal para ver la joyeria', 157.30, 3, 'joyas/cofre.jpg'),
(68, 'Collar de oro', 'Oro 14K entrelazado', 1500.00, 3, 'joyas/collar.jpg'),
(69, 'Collar', 'Plata con diamanes de sangre', 1430.00, 3, 'joyas/collar2.jpg'),
(70, 'Diadema', 'Placa de acero inoxidable con diamantes de fantasia', 230.00, 3, 'joyas/diadema.jpg'),
(71, 'Dige', 'Plata con cristal azul al centro', 199.99, 3, 'joyas/dige.jpg'),
(72, 'Juego de joyas', 'Aretes, Collar y anillo todo en oro blanco', 1888.90, 3, 'joyas/juego.jpg'),
(73, 'Muñequera', 'De aluminio estilo mallas', 339.99, 3, 'joyas/munequera.jpg'),
(74, 'Pasador', 'La mejor manera de estar a la moda y sin preocupaciones', 630.99, 3, 'joyas/pasador.jpg'),
(75, 'Percing', 'Plata sin preocupacion a infectarte', 650.00, 3, 'joyas/percingOrejero.jpg'),
(76, 'Pulsera', '3 oros y bronce con incrustaciones de diamantes', 1199.30, 3, 'joyas/pulsera.jpg'),
(77, 'Reloj Masculino', 'Ideal para conocer horas, minutos,segundos y fecha actual', 1353.00, 3, 'joyas/reloj.jpg'),
(78, 'Reloj de bolsillo', 'Cubrimiento de oro con correa larga', 1327.10, 3, 'joyas/relojBolsillo.jpg'),
(79, 'Reloj femenino', 'Oro blanco, delgado para discrecion', 1010.00, 3, 'joyas/relojFemenino.jpg'),
(80, 'Tobillera', 'Acero inoxidable bañano en oro fino', 990.90, 3, 'joyas/tobillera.jpg'),
(81, 'Alhondigas', 'Bolas de picadillo con spaguetti', 80.00, 1, 'comida/Alhondigas.jpg'),
(82, 'Brochetas', 'Camaron empanizado con frutas tropicales', 90.30, 1, 'comida/brochetas.jpg'),
(83, 'Carne asada', 'De cordero con su respectivo pico de gallo', 106.50, 1, 'comida/carneAsada.jpg'),
(84, 'Chocolate', 'Derretido a punto de turron', 54.00, 1, 'comida/chocolateDerretido.jpg'),
(85, 'Crepas', 'Dulces de jamon o lomo adobado', 46.90, 1, 'comida/crepas.jpg'),
(86, 'Donas', 'Glaseadas o con chispas de sabores', 25.50, 1, 'comida/donas.jpg'),
(87, 'Flan', 'Marca margarina con base de caramelo', 57.30, 1, 'comida/flan.jpg'),
(88, 'Flautas', 'De pollo en salsa verde', 55.00, 1, 'comida/flautas.jpg'),
(89, 'Gelatina', '100% fresas frecas con relleno de leche', 30.00, 1, 'comida/gelatina.jpg'),
(90, 'Hamburguesa', 'Doble cane c/papas a la francesa y verduras frescas', 68.00, 1, 'comida/hamburguesa.jpg'),
(91, 'Hot-cakes', 'Cuviertos con betum, algo diferente que te gustara', 79.99, 1, 'comida/HotCakes.jpg'),
(92, 'Hot-Dog', 'Extra grande, relleno de queso amarillo y tocino', 15.90, 1, 'comida/HotDog.jpg'),
(93, 'Mufin', 'Estilo Hello Kitty de fresa y chocolate', 59.99, 1, 'comida/mofinKelloKitty.jpg'),
(94, 'Nieves', 'De chocolate con chispas de chocolate bañadas en chocolate', 30.99, 1, 'comida/nieves.jpg'),
(95, 'Pan', 'Traido directamente desde Comala cubierto con chocolate', 15.00, 1, 'comida/pan.jpg'),
(96, 'Papas a la francesa', '0% sal 100%saludables', 61.30, 1, 'comida/papasFrancesas.jpg'),
(97, 'Pastel', 'De chocolate con relleno de cajeta', 253.00, 1, 'comida/pastelChocolate.jpg'),
(98, 'Pay', 'Queso de granjas Gonzalez con betum de ceresa', 27.10, 1, 'comida/payQueso.jpg'),
(99, 'Pizza', 'Grande de peperoni con bordos de queso mosarella', 130.00, 1, 'comida/pizza.jpg'),
(100, 'Tacos', 'Orden con 2 de labio, 2 al pastor y 1 de adobada', 50.90, 1, 'comida/tacos.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `id_Usuario` int(5) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `CURP` varchar(18) NOT NULL,
  `Direccion` varchar(255) NOT NULL,
  `Telefono` varchar(13) NOT NULL,
  `Correo` varchar(50) NOT NULL,
  `Contra` varchar(40) NOT NULL,
  UNIQUE KEY `id_Usuario` (`id_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
