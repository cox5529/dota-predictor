import React, { useEffect, useMemo, useState } from 'react';

import cx from 'classnames';

import { HeroResponse, HeroService } from '../api';
import HeroListHero from './HeroListHero';

type HeroListProps = {
  onSelection: (hero: HeroResponse, isRadiant: boolean) => void;
  dire: HeroResponse[];
  radiant: HeroResponse[];
};

const HeroList: React.FC<HeroListProps> = (props: HeroListProps) => {
  const [heroes, setHeroes] = useState<HeroResponse[]>([]);
  const visibleHeroes = useMemo(
    () => heroes.filter((x) => !props.dire.find((h) => h.id === x.id) && !props.radiant.find((h) => h.id === x.id)),
    [heroes, props.radiant, props.dire],
  );

  useEffect(() => {
    HeroService.getApiHero().then(setHeroes);
  }, []);

  return (
    <div className=''>
      <div className='overflow-auto max-h-full w-40'>
        {visibleHeroes.map((x) => (
          <HeroListHero key={x.id} hero={x} onSelection={props.onSelection} />
        ))}
      </div>
    </div>
  );
};

export default HeroList;
