import Footer from './Components/Footer';
import Header from './Components/Header';
import './globals.css';
import 'bootstrap/dist/css/bootstrap.min.css';

export default function RootLayout({ children }) {
	return (
		<html lang="pt-br">
			<body>
				<Header />
				<main className='container p-5'>{children}</main>
        		<Footer/>
				<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js"></script>
				<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
			</body>
		</html>
	)
}