import { Footer } from './components/Footer';
import { Header } from './components/Header';
import { HomeScreen } from './pages/HomeScreen'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import { ProductScreen } from './pages/ProductScreen'

function App() {
  return (
    <BrowserRouter>
      <Header />
      <main className='py-3'>
        <Routes>
          <Route path='/' element={<HomeScreen />} />
          <Route path='/product/:id' element={<ProductScreen />} />
        </Routes>
      </main>
      <Footer />
    </BrowserRouter>
  );
}

export default App;
