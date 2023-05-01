import React, { useState } from 'react';

import { HeroResponse } from './api';
import HeroList from './components/HeroList';
import TeamHeroList from './components/TeamHeroList';

function App() {
  const [dire, setDire] = useState<HeroResponse[]>([]);
  const [radiant, setRadiant] = useState<HeroResponse[]>([]);

  const onSelection = (hero: HeroResponse, isRadiant: boolean) => {
    if (isRadiant && radiant.length < 5) {
      setRadiant([...radiant, hero]);
    } else if (!isRadiant && dire.length < 5) {
      setDire([...dire, hero]);
    }
  };

  const onRemove = (hero: HeroResponse) => {
    setRadiant(radiant.filter(x => x.id !== hero.id));
    setDire(dire.filter(x => x.id !== hero.id));
  };

  return (
    <div className='bg-stone-700 text-white p-6 flex h-screen gap-8'>
      <HeroList onSelection={onSelection} dire={dire} radiant={radiant} />
      <div className='flex flex-col gap-4'>
        <TeamHeroList heroes={radiant} name={'Radiant'} onRemove={onRemove} />
        <TeamHeroList heroes={dire} name={'Dire'} onRemove={onRemove} />
      </div>
    </div>
  );
}

export default App;
