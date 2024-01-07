import Link from 'next/link'
import 'bootstrap/dist/css/bootstrap.min.css';

export default function Header() {
	return (

	<header className='container'>
	<nav className="navbar navbar-expand-lg">
  <div className="container-fluid">
  <img src="logo.png" alt="logo" /> <span className="logo-title"> GoTour </span>
    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-label="Toggle navigation">
      <span className="navbar-toggler-icon" />
    </button>
    <div className="collapse navbar-collapse" id="navbarNav">
      <ul className="navbar-nav text-white">
        <li className="nav-item">
          
		  <Link href="/API"> Destinos </Link>
          
        </li>
        <li className="nav-item">
          
		  <Link href="/Contato">Contatos</Link>
          
        </li>
      </ul>
    </div>
  </div>
</nav>
</header>
	)
}