-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 02-Jul-2018 às 15:05
-- Versão do servidor: 10.1.32-MariaDB
-- PHP Version: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lemais`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `nome` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(60) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `admins`
--

INSERT INTO `admins` (`id`, `nome`, `password`) VALUES
(1, 'paulo', 'paulo'),
(2, 'joao', 'joao');

-- --------------------------------------------------------

--
-- Estrutura da tabela `livros_venda`
--

CREATE TABLE `livros_venda` (
  `id_venda` int(11) NOT NULL,
  `isbn` varchar(200) NOT NULL,
  `titulo` varchar(200) NOT NULL,
  `autor` varchar(200) NOT NULL,
  `edicao` varchar(200) NOT NULL,
  `editora` varchar(200) NOT NULL,
  `data` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `estado` varchar(250) NOT NULL DEFAULT 'A ser entregue ...'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `ordens`
--

CREATE TABLE `ordens` (
  `id` int(15) NOT NULL,
  `isbn` varchar(255) NOT NULL,
  `titulo` varchar(255) NOT NULL,
  `sinopse` varchar(255) NOT NULL,
  `preco` int(10) NOT NULL,
  `unidades` int(5) NOT NULL,
  `total` int(15) NOT NULL,
  `data` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `email` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `id` int(11) NOT NULL,
  `isbn` varchar(60) CHARACTER SET latin1 NOT NULL,
  `titulo` varchar(60) CHARACTER SET latin1 NOT NULL,
  `autor` varchar(90) COLLATE utf8_unicode_ci NOT NULL,
  `edicao` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `editora` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `sinopse` tinytext CHARACTER SET latin1 NOT NULL,
  `imagem_produto` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `quantidade` int(5) NOT NULL,
  `preco` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`id`, `isbn`, `titulo`, `autor`, `edicao`, `editora`, `sinopse`, `imagem_produto`, `quantidade`, `preco`) VALUES
(1, '978-3-16-148410-0', 'Hidden', 'james Patterson', '2017', 'BookShoots', 'Emma, a personagem maior do livro, vive obcecada com a investigação de uma série de incêndios que, aos olhos dos restantes mortais, não passam de simples acidentes.', 'hidden.jpg', 3, '20.00'),
(2, '978-85-333-0227-3', 'Life after Life', 'Kate Atkinson', '2016', 'GooDreads', 'The novel has an unusual structure, repeatedly looping back in time to describe alternative possible lives for its central character, ', 'life_after_life.jpg', 3, '22.00'),
(3, '978-56-453-80227-2', 'Trinta Mil léguas submarinas', 'Júlio Verne', '2002', 'Hemus', ' O mistério que sempre envolveu o mar e o desafio que as profundezas marítimas exerceram em todas as épocas sobre os homens, desejosos de as conquistar, são temas eternos que alimentam a imaginação mítica de todas as gerações.', 'vinte_mil_leguas.jpg', 8, '21.00'),
(6, '928-99-226-246-45', 'Como a ciência funciona ', 'Luis Soares', '1994', 'Globo', 'O Método Científico é tradicionalmente introduzido no primeiro capítulo dos compêndios escolares de ciência como sendo uma simples receita.\n', 'como_ciencia_funciona.jpg', 5, '9.99'),
(7, '982-78-2124-101-678', 'Alma celta', 'Eduardo Amaro e Marcelo Moreira', '2014', 'Leya Brasil', 'Partindo de um episódio histórico real (a invasão dos milesianos na Irlanda), Alma Celta cria uma trama de ficção profundamente embasada na mitologia céltica.', 'alma_celta.jpg', 5, '4.99'),
(8, '978-853-5922-233-56', 'Toda Poesia', 'Paulo Leminski', '2013', 'Companhia das letras', 'Paulo Leminski foi corajoso o bastante para se equilibrar entre duas enormes construções que rivalizavam na década de 1970, quando publicava seus primeiros versos: a poesia concreta e de feição mais erudita. ', 'toda_poesia.jpg', 7, '8.99'),
(9, '654-28-1-894-6521-65', 'Uma aventura nas Férias de Natal', 'Ana Maria Magalhães', '1998', 'Editorial Caminho', 'A quinta onde o grupo passa férias de Natal fica no alto da Serra, num sítio muito isolado.', 'ferias_de_natal.jpg', 2, '7.50'),
(10, '658-3-5874-624-87', 'O universo numa casca de noz', 'Stephen hawking', '2002', 'Gradiva', 'O autor de “Uma Breve História do Tempo”, um dos nomes maiores da Física à escala planetária.', 'universo.jpg', 2, '39.00'),
(11, '97-804-252-055-18', 'The beginning', 'Catherine Coulter', '2005', 'Berkley Trade', 'Neste romance excitante de intriga, os leitores são apresentados aos Agentes Especiais Dillon Savich e Lacey Sherlock.', 'the_beginning.jpg', 6, '9.99'),
(12, '97-89-722-520-140', 'o símbolo perdido', 'Dan Brown', '2009', 'Bertrand Editora', 'Washington, D. C.: Robert Langdon, simbologista de Harvard, é convidado à última hora para dar uma palestra no Capitólio. Contudo, pouco depois da sua chegada, é descoberto no centro Rotunda um estranho objecto com cinco símbolos bizarros. \n', 'simbolo_perdido.jpg', 4, '19.99'),
(13, '982-3828-20-26', 'A montanha mágica', 'Thomas Mann', '2016', 'Editora Real', 'A Montanha Mágica (no original em alemão Der Zauberberg) é um livro escrito por Thomas Mann em 1924.', 'a_montanha.jpg', 1, '10.00'),
(14, '645-334-345-344', 'Cem Anos de Solidão', 'Garcia Márquez', '1982', 'Editorial Sudamericana', 'Considerado um dos melhores livros de literatura latina já escritos, sua história passa-se numa aldeia fictícia e remota na América Latina chamada Macondo.', 'cem_anos.jpg', 1, '10.00'),
(15, '23-246-752-781', 'The Big Short', 'Michael Lewis', '2010', 'W. W. Norton & Company', 'Em 2008, o guru de Wall Street Michael Burry percebe que uma série de empréstimos feitos para o mercado imobiliário está em risco de inadimplência.', 'big_short.jpg', 2, '14.00'),
(16, '47-66-4867-466', 'H is for Hank', 'Helen Macdonald', '2014', 'Jonathan Cape', 'H is for Hawk conta a história de Macdonald no ano em que passou a treinar um falcão na altura da morte do seu pai', 'h_hank.jpg', 6, '5.00'),
(17, '687-56-567-45', 'Porto Inseguro', 'Tana French', '2012', 'Rocco', 'O Livro Conta A História Do Detetive Mick Kennedy, Que Precisa de Enfrentar Os Próprios Demônios Enquanto Investiga A Morte De Três Membros De Uma Família No Mesmo Lugar Onde, Há Muitos Anos, Vivenciou Um Terrível Acontecimento Durante as suas férias ', 'porto_inseguro.jpg', 1, '9.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `utilizadores`
--

CREATE TABLE `utilizadores` (
  `id` int(11) NOT NULL,
  `primeiro` varchar(255) NOT NULL,
  `ultimo` varchar(255) NOT NULL,
  `morada` varchar(255) NOT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(15) NOT NULL,
  `tipo` varchar(20) NOT NULL DEFAULT 'user'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `utilizadores`
--

INSERT INTO `utilizadores` (`id`, `primeiro`, `ultimo`, `morada`, `cidade`, `email`, `password`, `tipo`) VALUES
(7, 'José', 'José', 'Rua dos noventas', 'VLC', 'dfg@sdfg.cv', 'cvb', 'user'),
(8, 'José', 'António', 'rua do vale', 'Aveiro', 'joseaugusto@mail.com', '123', 'user'),
(14, 'er', 'testeMudança', 'Rua das Flores, Nº 197', 'Arouca', 'er@er.er', 'qw', 'user'),
(15, 'wq', 'wq', 'Rua do vale ', 'zx', 'zx@zx', 'zx', 'user'),
(16, 'Almeida', 'Paulo', 'dfg', 'sdfg', 'rt@rt', 'rt', 'user'),
(17, 'qw', 'qw', 'qw', 'qw', 'qw@qw', 'qw', 'user'),
(20, 'José', 'qwe', 'qwe', 'qwe', 'rtt@er', 'qw', 'user'),
(21, 'ed', 'ed', 'ed', 'ed', 'ed@ed', 'ed', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `livros_venda`
--
ALTER TABLE `livros_venda`
  ADD PRIMARY KEY (`id_venda`);

--
-- Indexes for table `ordens`
--
ALTER TABLE `ordens`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `product_code` (`isbn`);

--
-- Indexes for table `utilizadores`
--
ALTER TABLE `utilizadores`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `livros_venda`
--
ALTER TABLE `livros_venda`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `ordens`
--
ALTER TABLE `ordens`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `utilizadores`
--
ALTER TABLE `utilizadores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
